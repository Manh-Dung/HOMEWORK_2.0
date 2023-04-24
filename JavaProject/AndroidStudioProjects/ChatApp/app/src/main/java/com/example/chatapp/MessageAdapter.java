package com.example.chatapp;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.LinearLayout;
import androidx.core.content.ContextCompat;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

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

    public void add(MessageModel messageModel){
        messageModelList.add(messageModel);
        notifyDataSetChanged();
    }

    public void clear(){
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
        String p = "2579";
        String g = "2";
        String a = "759";
        String oriMessage = "";
        String test = messageModelList.get(position).getMessage();
        String[] lines = test.split(";");

        for (String line : lines) {
            String[] parts = line.split(",");
            String y1 = parts[0];
            String y2 = parts[1];
            oriMessage = oriMessage + ChatActivity.decryptElgamal(p, a, y1, y2);
        }

        holder.msg.setText(oriMessage);
        if (messageModelList.get(position).getSenderId().equals(FirebaseAuth.getInstance().getUid())){
            holder.main.setBackgroundColor(ContextCompat.getColor(context,R.color.teal_700));
            holder.msg.setTextColor(ContextCompat.getColor(context,R.color.white));
        }
        else {
            holder.main.setBackgroundColor(ContextCompat.getColor(context,R.color.black));
            holder.msg.setTextColor(ContextCompat.getColor(context,R.color.white));
        }
    }

    @Override
    public int getItemCount() {
        return messageModelList.size();
    }

    public class ViewHolder extends RecyclerView.ViewHolder{
        private TextView msg;
        private LinearLayout main;
        public ViewHolder(@NonNull View itemView) {
            super(itemView);
            msg = itemView.findViewById(R.id.message);
            main = itemView.findViewById(R.id.mainMessageLayout);
        }
    }
}
