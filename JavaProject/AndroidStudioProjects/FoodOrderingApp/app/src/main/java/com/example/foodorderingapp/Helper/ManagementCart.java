package com.example.foodorderingapp.Helper;

import android.content.Context;
import android.widget.Toast;

import androidx.annotation.NonNull;

import com.example.foodorderingapp.Adaptor.Interface.ChangeNumberItemsListener;
import com.example.foodorderingapp.Domain.PopularDomain;

import java.util.ArrayList;

public class ManagementCart {
    private Context context;
    private TinyDB db;

    public ManagementCart(Context context) {
        this.context = context;
        this.db = new TinyDB(context);
    }

    public void insertFood(PopularDomain item) {
        // Khởi tạo giá trị của cái listFood bằng cái getListCart() luôn, cái list có key là CartList ấy 
        ArrayList<PopularDomain> listFood = getListCart();
        boolean existAlready = false;
        int n = 0;
        
        for (int i = 0; i < listFood.size(); i++) {
            // Nếu đã tồn tại cái mặt hàng có tiêu đề giống với tiêu đề cái item thì nó bảo mặt hàng đã tồn tại và break vòng lặp 
            // và set n = vị trí của mặt hàng đó 
            // Nó kiểu tìm tất cả các mặt hàng, trong trường hợp này là 3 
            if (listFood.get(i).getTitle().equals(item.getTitle())) {
                existAlready = true;
                n = i;
                break;
            }
        }

        // Nếu mặt hàng tồn tại thì set biến numberInCart bằng cái getNumberInCart của mặt hàng hiện tại
        if (existAlready) {
            listFood.get(n).setNumberInCart(item.getNumberInCart());
        // Nếu không thì thêm vào
        } else {
            listFood.add(item);
        }
        
        // Thêm vào cái database cái số lượng của mặt hàng hiện tại
        db.putListObject("CartList", listFood);
        Toast.makeText(context, "Added To Your Cart", Toast.LENGTH_SHORT).show();
    }

    // Tạo 1 cái list có key là CartList 
    public ArrayList<PopularDomain> getListCart() {
        return db.getListObject("CartList");
    }

    public void plusNumberFood(@NonNull ArrayList<PopularDomain> listFood, int position, @NonNull ChangeNumberItemsListener changeNumberItemsListener) {
        listFood.get(position).setNumberInCart(listFood.get(position).getNumberInCart() + 1);
        db.putListObject("CartList", listFood);
        changeNumberItemsListener.changed();
    }

    public void minusNumberFood(ArrayList<PopularDomain> listFood, int position, ChangeNumberItemsListener changeNumberItemsListener) {
        if (listFood.get(position).getNumberInCart() == 1) {
            listFood.remove(position);
        } else {
            listFood.get(position).setNumberInCart(listFood.get(position).getNumberInCart() - 1);
        }
        db.putListObject("CartList", listFood);
        changeNumberItemsListener.changed();
    }

    public int getTotalFee() {
        ArrayList<PopularDomain> listFood = getListCart();
        int fee = 0;
        for (int i = 0; i < listFood.size(); i++) {
            fee = fee + (listFood.get(i).getFee() * listFood.get(i).getNumberInCart());
        }
        return fee;
    }
}
