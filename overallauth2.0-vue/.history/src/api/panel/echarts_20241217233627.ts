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