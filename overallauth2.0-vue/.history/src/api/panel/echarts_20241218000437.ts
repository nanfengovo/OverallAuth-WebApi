
export const echartsOne = {
    title: {
    text: "系统六芒星图",
    },
    color: ['#67F9D8'],
    //backgroundColor: "#013954",  //背景样式
    radar: {
    // 雷达图的指示器，表示多个变量的标签
    indicator: [
        { name: "好用", max: 5 },
        { name: "易懂", max: 5 },
        { name: "简单", max: 5 },
        { name: "通用", max: 5 },
        { name: "灵活", max: 5 },
        { name: "学习", max: 5 },
    ],
    splitArea: {
        areaStyle: {
        color: ['#adbecf','#77EADF', '#26C3BE', '#64AFE9', '#428BD4','#2177cd'],
        shadowColor: 'rgba(0, 0, 0, 0.2)',
        shadowBlur: 10
        }
    },
    axisName: {
        formatter: '【{value}】',
        color: '#428BD4'
    },
    },
    series: [
    {
        type: "radar",
        // 雷达图的数据
        data: [
        {
            value: [5, 5, 5, 5, 5, 5],
        },
        ],
    },
    ],


    
};
//南丁格尔玫瑰图
export const echartsTWO = {
title: {
    text: "模块访问占比",
},
toolbox: {
    show: true,
},
legend: {
    bottom: "10",
},
// backgroundColor: "#013954",  //背景样式
series: [
    {
        name: "Nightingale Chart",
        type: "pie",
        radius: [25, 80],
        center: ["50%", "40%"],
        roseType: "area",
        // itemStyle: {
        //   borderRadius: 8,
        // },
        data: [
            { value: 40, name: "菜单权限" },
            { value: 38, name: "角色权限" },
            { value: 32, name: "列权限" },
            { value: 30, name: "行权限" },
            { value: 28, name: "按钮权限" },
            { value: 18, name: "接口权限" },
            { value: 26, name: "流程" },
            { value: 22, name: "表单" },
        ],
    },
],
};
import {ref} from 'vue';
//中国地图
export const chinaGeoCoordMap = ref<any>({
黑龙江: [127.9688, 45.368],
内蒙古: [110.3467, 41.4899],
吉林: [125.8154, 44.2584],
北京市: [116.4551, 40.2539],
辽宁: [123.1238, 42.1216],
河北: [114.4995, 38.1006],
天津: [117.4219, 39.4189],
山西: [112.3352, 37.9413],
陕西: [109.1162, 34.2004],
甘肃: [103.5901, 36.3043],
宁夏: [106.3586, 38.1775],
青海: [101.4038, 36.8207],
新疆: [87.9236, 43.5883],
西藏: [91.11, 29.97],
四川: [103.9526, 30.7617],
重庆: [108.384366, 30.439702],
山东: [117.1582, 36.8701],
河南: [113.4668, 34.6234],
江苏: [118.8062, 31.9208],
安徽: [117.29, 32.0581],
湖北: [114.3896, 30.6628],
浙江: [119.5313, 29.8773],
福建: [119.4543, 25.9222],
江西: [116.0046, 28.6633],
湖南: [113.0823, 28.2568],
贵州: [106.6992, 26.7682],
云南: [102.9199, 25.4663],
广东: [113.12244, 23.009505],
广西: [108.479, 23.1152],
海南: [110.3893, 19.8516],
上海: [121.4648, 31.2891],
});
export const chinaDatas = [
[
    {
        name: "黑龙江",
        value: 0,
    },
],
[
    {
        name: "内蒙古",
        value: 0,
    },
],
[
    {
        name: "吉林",
        value: 0,
    },
],
[
    {
        name: "辽宁",
        value: 0,
    },
],
[
    {
        name: "河北",
        value: 0,
    },
],
[
    {
        name: "天津",
        value: 0,
    },
],
[
    {
        name: "山西",
        value: 0,
    },
],
[
    {
        name: "陕西",
        value: 0,
    },
],
[
    {
        name: "甘肃",
        value: 0,
    },
],
[
    {
        name: "宁夏",
        value: 0,
    },
],
[
    {
        name: "青海",
        value: 0,
    },
],
[
    {
        name: "新疆",
        value: 0,
    },
],
[
    {
        name: "西藏",
        value: 0,
    },
],
[
    {
        name: "四川",
        value: 0,
    },
],
[
    {
        name: "重庆",
        value: 0,
    },
],
[
    {
        name: "山东",
        value: 0,
    },
],
[
    {
        name: "河南",
        value: 0,
    },
],
[
    {
        name: "江苏",
        value: 1,
    },
],
[
    {
        name: "安徽",
        value: 0,
    },
],
[
    {
        name: "湖北",
        value: 0,
    },
],
[
    {
        name: "浙江",
        value: 0,
    },
],
[
    {
        name: "福建",
        value: 0,
    },
],
[
    {
        name: "江西",
        value: 0,
    },
],
[
    {
        name: "湖南",
        value: 0,
    },
],
[
    {
        name: "贵州",
        value: 0,
    },
],
[
    {
        name: "广西",
        value: 0,
    },
],
[
    {
        name: "海南",
        value: 0,
    },
],
[
    {
        name: "上海",
        value: 0,
    },
],
];
var convertData = function (data: string | any[]) {
var res = [];
for (var i = 0; i < data.length; i++) {
    var dataItem = data[i];
    var fromCoord = chinaGeoCoordMap.value[dataItem[0].name];
    var toCoord = [103.9526, 30.7617];
    if (fromCoord && toCoord) {
        res.push([
            {
                coord: fromCoord,
                value: dataItem[0].value,
            },
            {
                coord: toCoord,
            },
        ]);
    }
}
return res;
};
export const series: {
type: string;
zlevel: number;
coordinateSystem: string;
effect: {
    show: boolean;
    period: number; //箭头指向速度，值越小速度越快
    trailLength: number; //特效尾迹长度[0,1]值越大，尾迹越长重
    symbol: string; //箭头图标
    symbolSize: number;
    brushType: string;
    scale: number
};
rippleEffect:any;
label: {},
symbol: string;
symbolSize: {},
itemStyle: {},
lineStyle: {
    normal: {
        width: number; //尾迹线条宽度
        opacity: number; //尾迹线条透明度
        curveness: number; //尾迹线条曲直度
    };
};
data: any
}[] = [];
[["江苏", chinaDatas as any]].forEach(function (item, i) {
series.push(
    {
        type: "lines",
        coordinateSystem: "geo",
        zlevel: 2,
        rippleEffect:[],
        effect: {
            show: true,
            period: 4, //箭头指向速度，值越小速度越快
            trailLength: 0.02, //特效尾迹长度[0,1]值越大，尾迹越长重
            symbol: "arrow", //箭头图标
            symbolSize: 5, //图标大小
            brushType: "",
            scale: 0
        },
        label: [],
        symbol: "",
        symbolSize: [],
        itemStyle: [],
        lineStyle: {
            normal: {
                width: 1, //尾迹线条宽度
                opacity: 1, //尾迹线条透明度
                curveness: 0.3, //尾迹线条曲直度
            },
        },
        data: convertData(item[1]),
    },
    {
        type: "effectScatter",
        coordinateSystem: "geo".toString(),
        zlevel: 2,
        effect:{} as any,
        rippleEffect: {
            //涟漪特效
            period: 4, //动画时间，值越小速度越快
            brushType: "stroke", //波纹绘制方式 stroke, fill
            scale: 4,
            show: false,
            trailLength: 0,
            symbol: "",
            symbolSize: 0
        },
        label: {
            normal: {
                show: true,
                position: "right", //显示位置
                offset: [5, 0], //偏移设置
                formatter: function (params: { data: { name: any } }) {
                    //圆环显示文字
                    return params.data.name;
                },
                fontSize: 13,
            },
            emphasis: {
                show: true,
            },
        },
        symbol: "circle",
        symbolSize: function (val: number[]) {
            return 5 + val[2] * 5; //圆环大小
        },
        itemStyle: {
            normal: {
                show: false,
                color: "#f00",
            },
        },
        lineStyle: {
            normal: {
                width: 1, //尾迹线条宽度
                opacity: 1, //尾迹线条透明度
                curveness: 0.3, //尾迹线条曲直度
            },
        },
        data: item[1].map(function (
            dataItem: {
                name: any;
                value: any;
            }[]
        ) {
            return {
                name: dataItem[0].name,
                value: chinaGeoCoordMap.value[dataItem[0].name].concat([dataItem[0].value]),
            };
        }),
    },
    //被攻击点
    {
        type: "scatter",
        coordinateSystem: "geo",
        zlevel: 2,
        rippleEffect:{} as any,
        effect: {
            period: 4,
            brushType: "stroke",
            scale: 4,
            show: false,
            trailLength: 0,
            symbol: "",
            symbolSize: 0
        },
        label: {
            normal: {
                show: true,
                position: "right",
                //offset:[5, 0],
                color: "#0f0",
                formatter: "{b}",
                textStyle: {
                    color: "#0f0",
                },
            },
            emphasis: {
                show: true,
                color: "#f60",
            },
        },
        symbol: "pin",
        symbolSize: 50,
        itemStyle: [],
        lineStyle: '' as any,
        data: [
            {
                name: item[0],
                value: chinaGeoCoordMap.value[item[0].toString()].concat([10]),
            },
        ],
    }
);
});
export const echartsThree = {
title: {
    text: "各省访问数量",
},
tooltip: {
trigger: "item",
backgroundColor: "rgba(166, 200, 76, 0.82)",
borderColor: "#FFFFCC",
showDelay: 0,
hideDelay: 0,
enterable: true,
transitionDuration: 0,
extraCssText: "z-index:100",
formatter: function (
    params: { name: any; value: { [x: string]: any }; seriesIndex: number },
    ticket: any,
    callback: any
) {
    //根据业务自己拓展要显示的内容
    var res = "";
    var name = params.name;
    var value = params.value[params.seriesIndex + 1];
    res =
    "<span style='color:#fff;'>" + name + "</span><br/>数据：" + value;
    return res;
},
},
//backgroundColor: "#013954",
visualMap: {
//图例值控制
min: 0,
max: 1,
calculable: true,
show: true,
color: ["#f44336", "#fc9700", "#ffde00", "#ffde00", "#00eaff"],
textStyle: {
    color: "#fff",
},
},
geo: {
map: "china",
zoom: 1.2,
label: {
    emphasis: {
    show: false,
    },
},
roam: false, //是否允许缩放
itemStyle: {
    normal: {
    color: "rgba(51, 69, 89, .5)", //地图背景色
    borderColor: "#516a89", //省市边界线00fcff 516a89
    borderWidth: 1,
    },
    emphasis: {
    color: "rgba(37, 43, 61, .5)", //悬浮背景
    },
},
},
series: series,
};

//堆叠图
export const echartsFour = {
title: {
text: "系统访问量走势图",
},
// backgroundColor: "#6a7985",  //背景样式
tooltip: {
trigger: "axis",
axisPointer: {
    type: "cross",
    label: {
    backgroundColor: "#6a7985",
    },
},
},
legend: {
data: ["菜单权限", "角色权限", "按钮权限", "行权限", "列权限"],
},
toolbox: {
// feature: {
//   saveAsImage: {},
// },
},
grid: {
left: "3%",
right: "4%",
bottom: "3%",
containLabel: true,
},
xAxis: [
{
    type: "category",
    boundaryGap: false,
    data: ["星期一", "星期二", "星期三", "星期四", "星期五", "星期六", "星期天"],
},
],
yAxis: [
{
    type: "value",
},
],
series: [
{
    name: "菜单权限",
    type: "line",
    stack: "Total",
    areaStyle: {},
    emphasis: {
    focus: "series",
    },
    data: [120, 132, 101, 134, 90, 230, 210],
},
{
    name: "角色权限",
    type: "line",
    stack: "Total",
    areaStyle: {},
    emphasis: {
    focus: "series",
    },
    data: [220, 182, 191, 234, 290, 330, 310],
},
{
    name: "按钮权限",
    type: "line",
    stack: "Total",
    areaStyle: {},
    emphasis: {
    focus: "series",
    },
    data: [150, 232, 201, 154, 190, 330, 410],
},
{
    name: "行权限",
    type: "line",
    stack: "Total",
    areaStyle: {},
    emphasis: {
    focus: "series",
    },
    data: [320, 332, 301, 334, 390, 330, 320],
},
{
    name: "列权限",
    type: "line",
    stack: "Total",
    label: {
    show: true,
    position: "top",
    },
    areaStyle: {},
    emphasis: {
    focus: "series",
    },
    data: [820, 932, 901, 934, 1290, 1330, 1320],
},
],
};