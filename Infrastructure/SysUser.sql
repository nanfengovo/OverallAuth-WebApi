
USE [OverallAuth]
GO
/****** Object:  Table [dbo].[Sys_User]    Script Date: 2024/10/6 10:38:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_User](
    [UserId] [int] IDENTITY(1,1) NOT NULL,
    [UserName] [varchar](50) NOT NULL,
    [Password] [varchar](50) NOT NULL,
    [Age] [int] NULL,
    [Sex] [int] NULL,
    [DepartmentId] [int] NOT NULL,
    [IsOpen] [bit] NULL,
    [CreateTime] [datetime] NULL,
    [CreateUser] [varchar](50) NULL,
 CONSTRAINT [PK_Sys_User] PRIMARY KEY CLUSTERED 
(
    [UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Sys_User] ON 

INSERT [dbo].[Sys_User] ([UserId], [UserName], [Password], [Age], [Sex], [DepartmentId], [IsOpen], [CreateTime], [CreateUser]) VALUES (1, N'����', N'1', 18, 1, 1, 1, CAST(N'2024-10-06T09:14:13.000' AS DateTime), N'1')
INSERT [dbo].[Sys_User] ([UserId], [UserName], [Password], [Age], [Sex], [DepartmentId], [IsOpen], [CreateTime], [CreateUser]) VALUES (2, N'����', N'1', 19, 1, 1, 1, CAST(N'2024-10-06T09:15:08.000' AS DateTime), N'1')
SET IDENTITY_INSERT [dbo].[Sys_User] OFF
ALTER TABLE [dbo].[Sys_User] ADD  DEFAULT ((0)) FOR [IsOpen]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�û�����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_User', @level2type=N'COLUMN',@level2name=N'UserName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�û�����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_User', @level2type=N'COLUMN',@level2name=N'Password'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�û�����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_User', @level2type=N'COLUMN',@level2name=N'Age'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�û����� 1:�� 2:Ů' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_User', @level2type=N'COLUMN',@level2name=N'Sex'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����id����Department������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_User', @level2type=N'COLUMN',@level2name=N'DepartmentId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_User', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������Ա' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_User', @level2type=N'COLUMN',@level2name=N'CreateUser'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��Ա��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_User'
GO
