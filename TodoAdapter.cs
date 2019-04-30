using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace MyHttpDemo
{
    public class TodoAdapter : RecyclerView.Adapter
    {
        public override int ItemCount => throw new NotImplementedException();

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            throw new NotImplementedException();
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            throw new NotImplementedException();
        }
    }

    public class TodoAdapterViewHolder : RecyclerView.ViewHolder
    {
        //Your adapter views to re-use
        public TextView TitleTextView { get; set; }
        public TextView UserIdTextView { get; set; }
        

        public TodoAdapterViewHolder(View itemView) : base(itemView)
        {
        }
    }
}