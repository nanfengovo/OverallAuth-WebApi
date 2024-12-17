<template>
  <div style="display: flex; height: 1080px">
    <div style="width: 80%">
      <div
        style="height: 25%; display: flex; margin-bottom: 5px" height="100px" width="100px"
        class="boxStyle"
      >
      <div id="echarts-one" style="width: 60%; height: 100%"></div>
        <div
          style="width: 50%; margin-left: 5px;"
          class="boxStyle"
        >
        <div id="echarts-two" style="width: 100%; height: 100%"></div>
        </div>
      </div>
      <div style="height: 45% ;margin-bottom: 5px"  class="boxStyle">
        <div id="echarts-three" style="width: 100%; height: 100%"></div>
      </div>
      <div style="height: 28%" class="boxStyle">
        <div id="echarts-four" style="width: 100%; height: 100%"></div>
      </div>
    </div>
    <div
      style="width: 20%; margin-left: 5px; display: flow-root"
      class="panelContent boxStyle"
    >
      <div
        style="width: 100%; height: 50%; margin-bottom: 5px"
        class="boxStyle"
      >
        特色功能
      </div>
      <div style="width: 100%; height: 50%" class="boxStyle">关于作者</div>
    </div>
  </div>
</template>
<script  lang="ts" >
import { echartsFour, echartsOne, echartsThree, echartsTWO } from "@/api/panel/echarts";
import * as echarts from "echarts";
import { defineComponent, onMounted } from "vue";
import chinaJson from '@/api/panel/china.json'


export default defineComponent({
  props: {
    // openPageData: {
    //   type: Object as PropType<buttonModel>,
    //   required: true,
    // },
  },

  setup() {  
    
    onMounted(() => {
      GetEchartsOneData();
      GetEchartsTwoData();
      GetEchartsThreeData();
      GetEchartsFourData();
    });

    //六芒星图
    function GetEchartsOneData() {
      var myChart = echarts.init(document.getElementById("echarts-one"));
      myChart.setOption(echartsOne);
    }

    //南丁格尔玫瑰图
    function GetEchartsTwoData() {
      var myChart = echarts.init(document.getElementById("echarts-two"));
      myChart.setOption(echartsTWO);
    }

    //中国地图
    function GetEchartsThreeData() {
      var myChart = echarts.init(document.getElementById("echarts-three"));
      echarts.registerMap("china", chinaJson as any); //注册可用的地图
      myChart.setOption(echartsThree);
    }

    //堆叠图
    function GetEchartsFourData() {
      var myChart = echarts.init(document.getElementById("echarts-four"));
      myChart.setOption(echartsFour);
      resizeEchart(myChart);
    }
    //图标兼容性调整
    function resizeEchart(myChart:any)
    {
      //监听窗口大小变化(适用于一个页面多个图形)
      window.addEventListener('resize',()=>{myChart.resize();})
    }
    return {};
  },
  components: {},
});
</script>
<style scoped>
.panelContent {
  font-size: 12px;
  justify-content: right;
  align-items: center;
}
.boxStyle {
  border: 1px solid #00152914;
  box-shadow: 0 1px 4px #00152914;
}
</style>