using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOybek.Services.ViewModels
{
    public class ListViewModel<T>
    {
        public List<T> Data { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}
