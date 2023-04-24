package com.example.foodorderingapp.Adaptor;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.LinearLayout;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.core.content.ContextCompat;
import androidx.recyclerview.widget.RecyclerView;

import com.example.foodorderingapp.Domain.MessageModel;
import com.example.foodorderingapp.R;
import com.google.firebase.auth.FirebaseAuth;

import java.util.ArrayList;
import java.util.List;

public class MessageAdapter extends RecyclerView.Adapter<MessageAdapter.ViewHolder> {
    private Context context;
    private List<MessageModel> messageModelList;

    public MessageAdapter(Context context) {
        this.context = context;
        messageModelList = new ArrayList<>();
    }

    public void add(MessageModel messageModel) {
        messageModelList.add(messageModel);
        notifyDataSetChanged();
    }

    public void clear() {
        messageModelList.clear();
        notifyDataSetChanged();
    }

    @NonNull
    @Override
    public ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View inflate = LayoutInflater.from(parent.getContext()).inflate(R.layout.message_row, parent, false);
        return new ViewHolder(inflate);
    }

    @Override
    public void onBindViewHolder(@NonNull ViewHolder holder, int position) {
        holder.msg.setText(messageModelList.get(position).getMessage());
        if (messageModelList.get(position).getSenderId().equals(FirebaseAuth.getInstance().getUid())) {
            holder.main.setBackgroundColor(ContextCompat.getColor(context, R.color.teal_700));
            holder.msg.setTextColor(ContextCompat.getColor(context, R.color.white));
        } else {
            holder.main.setBackgroundColor(ContextCompat.getColor(context, R.color.black));
            holder.msg.setTextColor(ContextCompat.getColor(context, R.color.white));
        }
    }

    @Override
    public int getItemCount() {
        return messageModelList.size();
    }

    public class ViewHolder extends RecyclerView.ViewHolder {
        private TextView msg;
        private LinearLayout main;

        public ViewHolder(@NonNull View itemView) {
            super(itemView);
            msg = itemView.findViewById(R.id.message);
            main = itemView.findViewById(R.id.mainMessageLayout);
        }
    }
}
