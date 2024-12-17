<template>
  <div>用户</div>
</template>
    
    <script lang="ts">
    import { defineComponent, onMounted } from "vue";
    import { TestAutofac } from "../../api/module/user";
    export default defineComponent({
        components: {},
        setup() {
    
        //初始加载
        onMounted(() => {
            TestAutofacMsg();
        });
        
        //调用接口
        const TestAutofacMsg = async () => {
            var result = await TestAutofac();
            console.log(result);
        };
        return {};
        },
    });
    </script>