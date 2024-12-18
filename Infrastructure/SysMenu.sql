CREATE TABLE [dbo].[Sys_Menu](
    [Id] [uniqueidentifier] NOT NULL,
    [Pid] [varchar](50) NOT NULL,
    [CorporationKey] [varchar](50) NOT NULL,
    [SystemKey] [varchar](50) NOT NULL,
    [MenuUrl] [varchar](50) NOT NULL,
    [MenuIcon] [varchar](50) NULL,
    [MenuTitle] [nvarchar](50) NOT NULL,
    [Component] [varchar](500) NOT NULL,
    [Sort] [int] NOT NULL,
    [IsOpen] [bit] NOT NULL,
    [CreateTime] [datetime] NOT NULL,
    [CreateUser] [varchar](50) NOT NULL,
    [RequireAuth] [bit] NULL,
    [Redirect] [varchar](500) NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Sys_Menu] ([Id], [Pid], [CorporationKey], [SystemKey], [MenuUrl], [MenuIcon], [MenuTitle], [Component], [Sort], [IsOpen], [CreateTime], [CreateUser], [RequireAuth], [Redirect]) VALUES (N'380ca40b-8b62-4ebe-86d7-91ae48292f43', N'0', N'6a75ec49-2093-4b89-950f-65e6e72746da', N'6e746ed0-12e9-4002-9887-d84a19142304', N'/panel', N'layui-icon-engine', N'工作空间', N'frameWork', 1, 1, CAST(N'2024-12-05T00:00:00.000' AS DateTime), N'1', 1, NULL)
INSERT [dbo].[Sys_Menu] ([Id], [Pid], [CorporationKey], [SystemKey], [MenuUrl], [MenuIcon], [MenuTitle], [Component], [Sort], [IsOpen], [CreateTime], [CreateUser], [RequireAuth], [Redirect]) VALUES (N'380ca40b-8b62-4ebe-86d7-91ae48292f44', N'380ca40b-8b62-4ebe-86d7-91ae48292f43', N'6a75ec49-2093-4b89-950f-65e6e72746da', N'6e746ed0-12e9-4002-9887-d84a19142304', N'/panel', N'layui-icon-engine', N'工作台', N'../views/panel/index', 1, 1, CAST(N'2024-12-05T00:00:00.000' AS DateTime), N'1', 1, NULL)
INSERT [dbo].[Sys_Menu] ([Id], [Pid], [CorporationKey], [SystemKey], [MenuUrl], [MenuIcon], [MenuTitle], [Component], [Sort], [IsOpen], [CreateTime], [CreateUser], [RequireAuth], [Redirect]) VALUES (N'380ca40b-8b62-4ebe-86d7-91ae48292f45', N'0', N'6a75ec49-2093-4b89-950f-65e6e72746da', N'6e746ed0-12e9-4002-9887-d84a19142304', N'/menu', N'layui-icon-engine', N'菜单管理', N'frameWork', 1, 1, CAST(N'2024-12-05T00:00:00.000' AS DateTime), N'1', 1, NULL)
INSERT [dbo].[Sys_Menu] ([Id], [Pid], [CorporationKey], [SystemKey], [MenuUrl], [MenuIcon], [MenuTitle], [Component], [Sort], [IsOpen], [CreateTime], [CreateUser], [RequireAuth], [Redirect]) VALUES (N'380ca40b-8b62-4ebe-86d7-91ae48292f46', N'380ca40b-8b62-4ebe-86d7-91ae48292f45', N'6a75ec49-2093-4b89-950f-65e6e72746da', N'6e746ed0-12e9-4002-9887-d84a19142304', N'/menu', N'layui-icon-engine', N'菜单', N'../views/menu/index', 1, 1, CAST(N'2024-12-05T00:00:00.000' AS DateTime), N'1', 1, NULL)
INSERT [dbo].[Sys_Menu] ([Id], [Pid], [CorporationKey], [SystemKey], [MenuUrl], [MenuIcon], [MenuTitle], [Component], [Sort], [IsOpen], [CreateTime], [CreateUser], [RequireAuth], [Redirect]) VALUES (N'380ca40b-8b62-4ebe-86d7-91ae48292f47', N'0', N'6a75ec49-2093-4b89-950f-65e6e72746da', N'6e746ed0-12e9-4002-9887-d84a19142304', N'/user', N'layui-icon-engine', N'用户管理', N'frameWork', 1, 1, CAST(N'2024-12-05T00:00:00.000' AS DateTime), N'1', 1, NULL)
INSERT [dbo].[Sys_Menu] ([Id], [Pid], [CorporationKey], [SystemKey], [MenuUrl], [MenuIcon], [MenuTitle], [Component], [Sort], [IsOpen], [CreateTime], [CreateUser], [RequireAuth], [Redirect]) VALUES (N'380ca40b-8b62-4ebe-86d7-91ae48292f48', N'380ca40b-8b62-4ebe-86d7-91ae48292f47', N'6a75ec49-2093-4b89-950f-65e6e72746da', N'6e746ed0-12e9-4002-9887-d84a19142304', N'/user', N'layui-icon-engine', N'用户', N'../views/user/index', 1, 1, CAST(N'2024-12-05T00:00:00.000' AS DateTime), N'1', 1, NULL)
ALTER TABLE [dbo].[Sys_Menu] ADD  CONSTRAINT [DF_Sys_Menu_Sort]  DEFAULT ((0)) FOR [Sort]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'菜单id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Menu', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'父级id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Menu', @level2type=N'COLUMN',@level2name=N'Pid'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'公司Key' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Menu', @level2type=N'COLUMN',@level2name=N'CorporationKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'系统Key' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Menu', @level2type=N'COLUMN',@level2name=N'SystemKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'菜单路径' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Menu', @level2type=N'COLUMN',@level2name=N'MenuUrl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'菜单图标' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Menu', @level2type=N'COLUMN',@level2name=N'MenuIcon'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'菜单标题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Menu', @level2type=N'COLUMN',@level2name=N'MenuTitle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排序' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Menu', @level2type=N'COLUMN',@level2name=N'Sort'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否开启菜单' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Menu', @level2type=N'COLUMN',@level2name=N'IsOpen'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Menu', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人员' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Menu', @level2type=N'COLUMN',@level2name=N'CreateUser'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否验证' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Menu', @level2type=N'COLUMN',@level2name=N'RequireAuth'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'重定向' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Menu', @level2type=N'COLUMN',@level2name=N'Redirect'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'菜单表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Menu'
GO