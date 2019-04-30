using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MyHttpDemo
{
    public class Todo
    {
        public int UserId { get; set; }

        public int Id { get; set; }

        public string Title { get; set; }

        public bool Completed { get; set; }
    }
}