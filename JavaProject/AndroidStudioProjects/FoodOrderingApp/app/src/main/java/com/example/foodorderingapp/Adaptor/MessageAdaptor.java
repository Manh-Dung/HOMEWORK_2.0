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

import com.example.foodorderingapp.Domain.MessageDomain;
import com.example.foodorderingapp.R;
import com.google.firebase.auth.FirebaseAuth;

import java.util.ArrayList;
import java.util.List;

public class MessageAdaptor extends RecyclerView.Adapter<MessageAdaptor.ViewHolder> {
    private Context context;
    private List<MessageDomain> messageDomainList;

    public MessageAdaptor(Context context) {
        this.context = context;
        messageDomainList = new ArrayList<>();
    }

    public void add(MessageDomain messageDomain) {
        messageDomainList.add(messageDomain);
        notifyDataSetChanged();
    }

    public void clear() {
        messageDomainList.clear();
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
        holder.msg.setText(messageDomainList.get(position).getMessage());
        if (messageDomainList.get(position).getSenderId().equals(FirebaseAuth.getInstance().getUid())) {
            holder.main.setBackgroundColor(ContextCompat.getColor(context, R.color.login_form));
            holder.msg.setTextColor(ContextCompat.getColor(context, R.color.white));
        } else {
            holder.main.setBackgroundColor(ContextCompat.getColor(context, R.color.chat));
            holder.msg.setTextColor(ContextCompat.getColor(context, R.color.black));
        }
    }

    @Override
    public int getItemCount() {
        return messageDomainList.size();
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
