<template>
  <div style="display: flex; height: 1080px">
    <div style="width: 80%">
      <div
        style="height: 25%; display: flex; margin-bottom: 5px"
        class="boxStyle"
      >
      <div id="echarts-one" style="width: 100%; height: 100%"></div>
        <div
          style="width: 50%; margin-left: 5px;"
          class="boxStyle"
        >
        2
        </div>
      </div>
      <div style="height: 45% ;margin-bottom: 5px"  class="boxStyle">
      3
      </div>
      <div style="height: 28%" class="boxStyle">
        4
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
import * as echarts from "echarts";
import { echartsOne } from "@/api/panel/echarts";
import { defineComponent, onMounted } from "vue";
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
    });
    function GetEchartsOneData() {
      var myChart = echarts.init(document.getElementById("echarts-one"));
      myChart.setOption(echartsOne);
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