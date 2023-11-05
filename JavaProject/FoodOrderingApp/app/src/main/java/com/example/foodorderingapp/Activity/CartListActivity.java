package com.example.foodorderingapp.Activity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.LinearLayout;
import android.widget.ScrollView;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.content.ContextCompat;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.example.foodorderingapp.Adaptor.CartListAdaptor;
import com.example.foodorderingapp.Adaptor.Interface.ChangeNumberItemsListener;
import com.example.foodorderingapp.Domain.NotificationDomain;
import com.example.foodorderingapp.Helper.ManagementCart;
import com.example.foodorderingapp.R;
import com.google.android.material.floatingactionbutton.FloatingActionButton;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;

import java.text.SimpleDateFormat;

public class CartListActivity extends AppCompatActivity {
    private RecyclerView.Adapter adapter;
    private RecyclerView recyclerViewList;
    private ManagementCart managementCart;
    DatabaseReference databaseReference = FirebaseDatabase.getInstance().getReference("notifications");

    TextView totalFeeTxt, taxTxt, deliveryTxt, totalTxt, emptyTxt, checkOutBtn;
    private int tax;
    private ScrollView scrollView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_cartlist);

        managementCart = new ManagementCart(this);
        initView();
        initList();
        CalculateCart();
        bottomNavigation();
    }

    private void bottomNavigation() {
        FloatingActionButton floatingActionButton = findViewById(R.id.cartBtn);
        LinearLayout homeBtn = findViewById(R.id.homeBtn);
        LinearLayout profileBtn = findViewById(R.id.profileBtn);
        LinearLayout settingBtn = findViewById(R.id.settingBtn);
        LinearLayout supportBtn = findViewById(R.id.supportBtn);

        floatingActionButton.setOnClickListener(view -> startActivity(new Intent(CartListActivity.this, CartListActivity.class)));

        homeBtn.setOnClickListener(view -> startActivity(new Intent(CartListActivity.this, MainActivity.class)));

        profileBtn.setOnClickListener(view -> startActivity(new Intent(CartListActivity.this, ProfileActivity.class)));

        settingBtn.setOnClickListener(view -> startActivity(new Intent(CartListActivity.this, SettingActivity.class)));

        supportBtn.setOnClickListener(view -> startActivity(new Intent(CartListActivity.this, SupportActivity.class)));

        checkOutBtn.setOnClickListener(view -> {
            checkOutBtn.setText("Đã thanh toán");
            checkOutBtn.setTextColor(ContextCompat.getColor(getApplicationContext(), R.color.login_form));
            checkOutBtn.setBackground(ContextCompat.getDrawable(getApplicationContext(), R.drawable.white_button));

            long millis = System.currentTimeMillis();
            java.util.Date time = new java.util.Date(millis);

            SimpleDateFormat dateFormat = new SimpleDateFormat("HH:mm dd-MM-yyyy");
            String curTime = dateFormat.format(time);

            NotificationDomain notificationDomain = new NotificationDomain(curTime + FirebaseAuth.getInstance().getUid(),
                    FirebaseAuth.getInstance().getUid(),
                    curTime,
                    "1");
            databaseReference.child(FirebaseAuth.getInstance().getUid())
                    .child(curTime + FirebaseAuth.getInstance().getUid())
                    .setValue(notificationDomain);
        });
    }

    private void initView() {
        recyclerViewList = findViewById(R.id.cartList);
        totalFeeTxt = findViewById(R.id.totalFeeTxt);
        deliveryTxt = findViewById(R.id.deliveryTxt);
        taxTxt = findViewById(R.id.taxTxt);
        totalTxt = findViewById(R.id.totalTxt);
        emptyTxt = findViewById(R.id.emptyTxt);
        scrollView = findViewById(R.id.scrollView3);
        recyclerViewList = findViewById(R.id.cartList);
        checkOutBtn = findViewById(R.id.checkOutBtn);
    }

    private void initList() {
        LinearLayoutManager linearLayoutManager = new LinearLayoutManager(this, LinearLayoutManager.VERTICAL, false);
        recyclerViewList.setLayoutManager(linearLayoutManager);
        adapter = new CartListAdaptor(managementCart.getListCart(), this, () -> CalculateCart());

        recyclerViewList.setAdapter(adapter);
        if (managementCart.getListCart().isEmpty()) {
            emptyTxt.setVisibility(View.VISIBLE);
            scrollView.setVisibility(View.GONE);
        } else {
            emptyTxt.setVisibility(View.GONE);
            scrollView.setVisibility(View.VISIBLE);
        }
    }

    private void CalculateCart() {
        double percentTax = 0.02;
        int delivery = 10000;

        tax = (int) (managementCart.getTotalFee() * percentTax);
        int total = managementCart.getTotalFee() + tax + delivery;
        int itemTotal = managementCart.getTotalFee();

        totalFeeTxt.setText(itemTotal + "vnđ");
        taxTxt.setText(tax + "vnđ");
        deliveryTxt.setText(delivery + "vnđ");
        totalTxt.setText(total + "vnđ");
    }
}