package com.example.loadingdata;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.bumptech.glide.Glide;
import com.squareup.picasso.Picasso;

import java.util.ArrayList;
import java.util.List;

public class ShoeAdaptor extends RecyclerView.Adapter<ShoeAdaptor.ViewHolder>{
    List<ShoeDomain> shoeDomainList;

    public ShoeAdaptor(List<ShoeDomain> shoeDomainList) {
        this.shoeDomainList = shoeDomainList;
    }

    @NonNull
    @Override
    public ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View inflate = LayoutInflater.from(parent.getContext()).inflate(R.layout.shoe_item, parent, false);
        return new ViewHolder(inflate);
    }

    @Override
    public void onBindViewHolder(@NonNull ShoeAdaptor.ViewHolder holder, int position) {
        Picasso.get().load(shoeDomainList.get(position).getSearch_image()).into(holder.shoe_pic);
//        Glide.with(holder.itemView.getContext()).load(shoeDomainList.get(position).getSearch_image()).into(holder.shoe_pic);
        holder.styleidTxt.setText(String.valueOf(shoeDomainList.get(position).getStyleid()));
        holder.brands_filter_facetTxt.setText(shoeDomainList.get(position).getBrands_filter_facet());
        holder.priceTxt.setText(String.valueOf(shoeDomainList.get(position).getPrice()));
        holder.product_additional_infoTxt.setText(shoeDomainList.get(position).getProduct_additional_info());
    }

    @Override
    public int getItemCount() {
        return shoeDomainList.size();
    }

    public class ViewHolder extends RecyclerView.ViewHolder {
        TextView styleidTxt, brands_filter_facetTxt, priceTxt, product_additional_infoTxt;
        ImageView shoe_pic;
        public ViewHolder(@NonNull View itemView) {
            super(itemView);
            styleidTxt = itemView.findViewById(R.id.styleidTxt);
            brands_filter_facetTxt = itemView.findViewById(R.id.brands_filter_facetTxt);
            priceTxt = itemView.findViewById(R.id.priceTxt);
            product_additional_infoTxt = itemView.findViewById(R.id.product_additional_infoTxt);
            shoe_pic = itemView.findViewById(R.id.shoe_pic);
        }
    }
}
