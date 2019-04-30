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
        List<Todo> _todos;

        public TodoAdapter(List<Todo> todos)
        {
            _todos = todos;
        }
        public override int ItemCount => _todos.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            TodoAdapterViewHolder viewHolder = holder as TodoAdapterViewHolder;
            viewHolder.TitleTextView.Text = _todos[position].Title;
            viewHolder.UserIdTextView.Text = _todos[position].UserId.ToString();
            viewHolder.CompletedCheckBox.Checked = _todos[position].Completed;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var inflater = LayoutInflater.FromContext(parent.Context);
            View itemView = inflater.Inflate(Resource.Layout.todo_cardview, parent, false);
            TodoAdapterViewHolder viewHolder = new TodoAdapterViewHolder(itemView);
            return viewHolder;
        }
    }

    public class TodoAdapterViewHolder : RecyclerView.ViewHolder
    {
        //Your adapter views to re-use
        public TextView TitleTextView { get; private set; }
        public TextView UserIdTextView { get; private set; }        
        public CheckBox CompletedCheckBox { get; private set; }

        public TodoAdapterViewHolder(View itemView) : base(itemView)
        {
            TitleTextView = itemView.FindViewById<TextView>(Resource.Id.title);
            UserIdTextView = itemView.FindViewById<TextView>(Resource.Id.userId);
            CompletedCheckBox = itemView.FindViewById<CheckBox>(Resource.Id.completed);
        }
    }
}