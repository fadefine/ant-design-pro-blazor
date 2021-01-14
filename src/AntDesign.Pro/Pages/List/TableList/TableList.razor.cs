using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AntDesign.Pro.Template.Models;

namespace AntDesign.Pro.Template.Pages.List
{
    public partial class TableList
    {
        private readonly TableListModel _model = new TableListModel();
        bool loading = false;
        /// <summary>
        /// 提交
        /// </summary>
        private void HandleSubmit()
        {
            //todo 提交查询事件
        }

        private void enterLoading()
        {
            loading = true;
            Task.Run(async () =>
            {
                await Task.Delay(8000);//休眠8秒
                loading = false;
                await InvokeAsync(StateHasChanged);//重新渲染组件
                //Console.WriteLine("Timer2 ended" + DateTime.Now);
            });
        }
    }
}