package com.example.foodorderingapp.Adaptor;

import android.content.Context;
import android.content.Intent;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.core.content.ContextCompat;
import androidx.recyclerview.widget.RecyclerView;

import com.bumptech.glide.Glide;
import com.example.foodorderingapp.Activity.MainActivity;
import com.example.foodorderingapp.Activity.ShowDetailActivity;
import com.example.foodorderingapp.Domain.MessageDomain;
import com.example.foodorderingapp.Domain.NotificationDomain;
import com.example.foodorderingapp.Domain.PopularDomain;
import com.example.foodorderingapp.R;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;

import java.text.SimpleDateFormat;
import java.util.ArrayList;

public class NotificationAdaptor extends RecyclerView.Adapter<NotificationAdaptor.ViewHolder> {
    DatabaseReference databaseReference = FirebaseDatabase.getInstance().getReference("notifications");

    ArrayList<NotificationDomain> notiList;
    private Context context;

    public NotificationAdaptor(Context context) {
        this.context = context;
        this.notiList = new ArrayList<>();
    }

    public void add(NotificationDomain notificationDomain) {
        notiList.add(notificationDomain);
        notifyDataSetChanged();
    }

    public void clear() {
        notiList.clear();
        notifyDataSetChanged();
    }

    @Override
    public NotificationAdaptor.ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View inflate = LayoutInflater.from(parent.getContext()).inflate(R.layout.viewholder_notification, parent, false);
        return new ViewHolder(inflate);
    }

    @Override
    public void onBindViewHolder(@NonNull NotificationAdaptor.ViewHolder holder, int position) {
        NotificationDomain notification = notiList.get(position);
        if (notification.getIsRead().equals("false")){
            if (notification.getNotiType().equals("1") ){
                holder.notiTitle.setText("Đơn hàng đã được thanh toán vào " + notification.getTime());
                holder.notiType.setText("Đơn hàng đang được giao");
                holder.checkOutLayout.setVisibility(View.VISIBLE);

                holder.receivedBtn.setOnClickListener(new View.OnClickListener() {
                    @Override
                    public void onClick(View view) {
                        long millis = System.currentTimeMillis();
                        java.util.Date time = new java.util.Date(millis);

                        SimpleDateFormat dateFormat = new SimpleDateFormat("HH:mm dd-MM-yyyy");
                        String curTime = dateFormat.format(time);

                        holder.notiPic.setVisibility(View.GONE);
                        notification.setIsRead("true");
                        holder.notiTitle.setTextColor(ContextCompat.getColor(context, R.color.black));
                        holder.notiType.setTextColor(ContextCompat.getColor(context, R.color.black));

                        NotificationDomain notificationDomain = new NotificationDomain(curTime + FirebaseAuth.getInstance().getUid(),
                                FirebaseAuth.getInstance().getUid(),
                                curTime,
                                "2");
                        notiList.add(notificationDomain);
                        databaseReference.child(FirebaseAuth.getInstance().getUid())
                                .child(curTime + FirebaseAuth.getInstance().getUid())
                                .setValue(notificationDomain);

                        holder.checkOutLayout.setVisibility(View.GONE);
                    }
                });

                holder.cancelBtn.setOnClickListener(new View.OnClickListener() {
                    @Override
                    public void onClick(View view) {
                        long millis = System.currentTimeMillis();
                        java.util.Date time = new java.util.Date(millis);

                        SimpleDateFormat dateFormat = new SimpleDateFormat("HH:mm dd-MM-yyyy");
                        String curTime = dateFormat.format(time);

                        holder.notiPic.setVisibility(View.GONE);
                        notification.setIsRead("true");
                        holder.notiTitle.setTextColor(ContextCompat.getColor(context, R.color.black));
                        holder.notiType.setTextColor(ContextCompat.getColor(context, R.color.black));

                        NotificationDomain notificationDomain = new NotificationDomain(curTime + FirebaseAuth.getInstance().getUid(),
                                FirebaseAuth.getInstance().getUid(),
                                curTime,
                                "3");
                        notiList.add(notificationDomain);
                        databaseReference.child(FirebaseAuth.getInstance().getUid())
                                .child(curTime + FirebaseAuth.getInstance().getUid())
                                .setValue(notificationDomain);

                        holder.checkOutLayout.setVisibility(View.GONE);
                    }
                });
            }
            else if (notification.getNotiType().equals("2")) {
                holder.notiTitle.setText("Đơn hàng đã được nhận thành công vào " + notiList.get(position).getTime());
                holder.notiType.setText("Đơn hàng đã được nhận");
            }
            else if (notification.getNotiType().equals("3")){
                holder.notiTitle.setText("Đơn hàng đã được hủy thành công vào " + notiList.get(position).getTime());
                holder.notiType.setText("Đơn hàng đã được hủy");
            }
            holder.itemView.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View view) {
                    holder.notiPic.setVisibility(View.GONE);
                    notification.setIsRead("true");
                    holder.notiTitle.setTextColor(ContextCompat.getColor(context, R.color.black));
                    holder.notiType.setTextColor(ContextCompat.getColor(context, R.color.black));
                }
            });
        }
        else if (notification.getIsRead().equals("true")){
            if (notification.getNotiType().equals("1")){
                holder.notiPic.setVisibility(View.GONE);
                holder.notiTitle.setTextColor(ContextCompat.getColor(context, R.color.black));
                holder.notiType.setTextColor(ContextCompat.getColor(context, R.color.black));
                holder.notiTitle.setText("Đơn hàng đã được thanh toán vào " + notification.getTime());
                holder.notiType.setText("Đơn hàng đang được giao");
                holder.checkOutLayout.setVisibility(View.VISIBLE);

                holder.receivedBtn.setOnClickListener(new View.OnClickListener() {
                    @Override
                    public void onClick(View view) {
                        long millis = System.currentTimeMillis();
                        java.util.Date time = new java.util.Date(millis);

                        SimpleDateFormat dateFormat = new SimpleDateFormat("HH:mm dd-MM-yyyy");
                        String curTime = dateFormat.format(time);

                        NotificationDomain notificationDomain = new NotificationDomain(curTime + FirebaseAuth.getInstance().getUid(),
                                FirebaseAuth.getInstance().getUid(),
                                curTime,
                                "2");
                        notiList.add(notificationDomain);
                        databaseReference.child(FirebaseAuth.getInstance().getUid())
                                .child(curTime + FirebaseAuth.getInstance().getUid())
                                .setValue(notificationDomain);

                        holder.checkOutLayout.setVisibility(View.GONE);
                    }
                });

                holder.cancelBtn.setOnClickListener(new View.OnClickListener() {
                    @Override
                    public void onClick(View view) {
                        long millis = System.currentTimeMillis();
                        java.util.Date time = new java.util.Date(millis);

                        SimpleDateFormat dateFormat = new SimpleDateFormat("HH:mm dd-MM-yyyy");
                        String curTime = dateFormat.format(time);

                        NotificationDomain notificationDomain = new NotificationDomain(curTime + FirebaseAuth.getInstance().getUid(),
                                FirebaseAuth.getInstance().getUid(),
                                curTime,
                                "3");
                        notiList.add(notificationDomain);
                        databaseReference.child(FirebaseAuth.getInstance().getUid())
                                .child(curTime + FirebaseAuth.getInstance().getUid())
                                .setValue(notificationDomain);

                        holder.checkOutLayout.setVisibility(View.GONE);
                    }
                });
            }
            else if (notification.getNotiType().equals("2")) {
                holder.notiTitle.setText("Đơn hàng đã được nhận thành công vào lúc " + notiList.get(position).getTime());
                holder.notiType.setText("Đơn hàng đã được nhận");

                holder.notiPic.setVisibility(View.GONE);
            }
            else {
                holder.notiTitle.setText("Đơn hàng đã được hủy thành công vào lúc " + notiList.get(position).getTime());
                holder.notiType.setText("Đơn hàng đã được hủy");

                holder.notiPic.setVisibility(View.GONE);
            }
        }
    }

    @Override
    public int getItemCount() {
        return notiList.size();
    }

    public class ViewHolder extends RecyclerView.ViewHolder {

        private TextView notiTitle, notiType, receivedBtn, cancelBtn;
        private LinearLayout checkOutLayout;
        private ImageView notiPic;

        public ViewHolder(@NonNull View itemView) {
            super(itemView);
            notiTitle = itemView.findViewById(R.id.notiTitle);
            notiType = itemView.findViewById(R.id.notiType);
            receivedBtn = itemView.findViewById(R.id.receivedBtn);
            cancelBtn = itemView.findViewById(R.id.cancelBtn);
            checkOutLayout = itemView.findViewById(R.id.checkOutLayout);
            notiPic = itemView.findViewById(R.id.notiPic);
        }
    }
}
