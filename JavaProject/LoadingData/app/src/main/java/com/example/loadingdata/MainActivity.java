package com.example.loadingdata;

import android.os.Bundle;
import android.util.Log;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.GridLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.android.volley.Request;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.JsonObjectRequest;
import com.android.volley.toolbox.Volley;
import com.google.gson.Gson;
import com.google.gson.reflect.TypeToken;

import org.json.JSONException;
import org.json.JSONObject;

import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {
    private RecyclerView.Adapter adapter;
    RecyclerView recyclerView;
    private List<ShoeDomain> itemList;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        // Dùng GridLayout để hiển thị dữ liệu dạng lưới với 2 cột
        GridLayoutManager gridLayoutManager = new GridLayoutManager(this, 2);
        recyclerView = findViewById(R.id.recyclerView);
        recyclerView.setLayoutManager(gridLayoutManager);

        itemList = new ArrayList<>();
        adapter = new ShoeAdaptor(itemList);
        recyclerView.setAdapter(adapter);

        // Lấy dữ liệu từ đường dẫn
        String url = "https://hungnttg.github.io/shopgiay.json";
        JsonObjectRequest jsonObjectRequest = new JsonObjectRequest(Request.Method.GET, url, null,
                new Response.Listener<JSONObject>() {
                    @Override
                    public void onResponse(JSONObject response) {
                        // Chuyển đổi dữ liệu JSON thành đối tượng Java bằng Gson
                        Gson gson = new Gson();
                        Type type = new TypeToken<List<ShoeDomain>>() {
                        }.getType();
                        List<ShoeDomain> items = null;
                        try {
                            items = gson.fromJson(response.getJSONArray("products").toString(), type);
                        } catch (JSONException e) {
                            throw new RuntimeException(e);
                        }

                        // Thêm dữ liệu vào danh sách và cập nhật Adapter
                        itemList.addAll(items);
                        adapter.notifyDataSetChanged();
                    }
                },
                new Response.ErrorListener() {
                    @Override
                    public void onErrorResponse(VolleyError error) {
                        Log.e("ERROR", error.getMessage());
                    }
                });

        // Thêm request vào hàng đợi
        Volley.newRequestQueue(this).add(jsonObjectRequest);
    }

}