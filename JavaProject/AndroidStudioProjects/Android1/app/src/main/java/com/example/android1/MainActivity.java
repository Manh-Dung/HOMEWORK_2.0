package com.example.android1;

import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import com.example.android1.databinding.ActivityMainBinding;

import java.text.DecimalFormat;
import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {
    Button btnXoa, btnAm, btnMod, btnChia, btn7, btn8, btn9, btn1, btn2, btn3, btn4, btn5, btn6, btnCong, btnTru, btnNhan, btn0, btnPhay, btnBang;
    TextView tvDisplay;
    String a = "0", b = "0";
    float flA = 0, flB = 0, result = 0;
    int sauBang = 1;

    @SuppressLint("MissingInflatedId")
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        btnXoa = findViewById(R.id.btnXoa);
        btnAm = findViewById(R.id.btnAm);
        btnMod = findViewById(R.id.btnMod);
        btnChia = findViewById(R.id.btnChia);
        btn7 = findViewById(R.id.btn7);
        btn8 = findViewById(R.id.btn8);
        btn9 = findViewById(R.id.btn9);
        btn6 = findViewById(R.id.btn6);
        btn5 = findViewById(R.id.btn5);
        btn4 = findViewById(R.id.btn4);
        btn3 = findViewById(R.id.btn3);
        btn2 = findViewById(R.id.btn2);
        btn1 = findViewById(R.id.btn1);
        btn0 = findViewById(R.id.btn0);
        btnCong = findViewById(R.id.btnCong);
        btnNhan = findViewById(R.id.btnNhan);
        btnPhay = findViewById(R.id.btnPhay);
        btnTru = findViewById(R.id.btnTru);
        btnBang = findViewById(R.id.btnBang);
        tvDisplay = findViewById(R.id.tvDisplay);
    }

    public int checkDau() {
        if (tvDisplay.getText().toString().contains("+") || tvDisplay.getText().toString().contains("-") || tvDisplay.getText().toString().contains("*") || tvDisplay.getText().toString().contains("/")) {
            return 1;
        } else {
            return 0;
        }
    }

    public int checkPhanTram() {
        if (tvDisplay.getText().toString().contains("%")) {
            return 1;
        } else {
            return 0;
        }
    }

    public void anSo(int so) {
        String stSo = Integer.toString(so);
        if (sauBang == 1) {
            tvDisplay.setText("");
            tvDisplay.setText(tvDisplay.getText() + stSo);
            sauBang = 0;
            if (checkDau() == 0 && checkPhanTram() == 0) {
                a = a + stSo;
                flA = Float.parseFloat(a);
            }
            if (checkDau() == 1 || checkPhanTram() == 1) {
                b = b + stSo;
                flB = Float.parseFloat(b);
            }
        } else {
            tvDisplay.setText(tvDisplay.getText() + stSo);
            sauBang = 0;
            if (checkDau() == 0 && checkPhanTram() == 0) {
                a = a + stSo;
                flA = Float.parseFloat(a);
            }
            if (checkDau() == 1 || checkPhanTram() == 1) {
                b = b + stSo;
                flB = Float.parseFloat(b);
            }
        }
    }

    public void Xoa(View view) {
        tvDisplay.setText("0");
    }

    public void Am(View view) {
        tvDisplay.setText(tvDisplay.getText() + "-");
        if (checkDau() == 1 || checkPhanTram() == 1) {
            b = "";
            b = b + "-";
            flB = Float.parseFloat(b);
        }
    }

    public void Mod(View view) {
        tvDisplay.setText(tvDisplay.getText() + " % ");
    }

    public void Chia(View view) {
        tvDisplay.setText(tvDisplay.getText() + " / ");
    }

    public void So7(View view) {
        anSo(7);
    }

    public void So8(View view) {
        anSo(8);
    }

    public void So9(View view) {
        anSo(9);
    }

    public void Nhan(View view) {
        tvDisplay.setText(tvDisplay.getText() + " * ");
    }

    public void So4(View view) {
        anSo(4);
    }

    public void So5(View view) {
        anSo(5);
    }

    public void So6(View view) {
        anSo(6);
    }

    public void So1(View view) {
        anSo(1);
    }

    public void Tru(View view) {
        tvDisplay.setText(tvDisplay.getText() + " - ");
    }

    public void So2(View view) {
        anSo(2);
    }

    public void So3(View view) {
        anSo(3);
    }

    public void Cong(View view) {
        tvDisplay.setText(tvDisplay.getText() + " + ");
    }

    public void So0(View view) {
        anSo(0);
    }

    public void Phay(View view) {
        tvDisplay.setText(tvDisplay.getText() + ".");
        if (checkDau() == 0 && checkPhanTram() == 0) {
            a = a + ".";
            flA = Float.parseFloat(a);
        }
        if (checkDau() == 1 || checkPhanTram() == 1) {
            b = b + ".";
            flB = Float.parseFloat(b);
        }
    }

    public void Bang(View view) {
        tvDisplay.setText(tvDisplay.getText() + " = ");
        flA = Float.parseFloat(a);
        flB = Float.parseFloat(b);

        if (tvDisplay.getText().toString().contains("+")) {
            result = flA + flB;
        }
        else if (tvDisplay.getText().toString().contains("-")) {
            result = flA - flB;
        }
        else if (tvDisplay.getText().toString().contains("*")) {
            result = flA * flB;
        }
        else if (tvDisplay.getText().toString().contains("/")) {
            result = flA / flB;
        }
        else if (tvDisplay.getText().toString().contains("%")) {
            if (checkPhanTram() == 1 && checkDau() == 0 && flB == 0) {
                result = flA / 100;
            } else {
                int iA = (int) flA;
                int iB = (int) flB;
                result = iA % iB;
            }
        }
        else {
            result = flA;
        }

        tvDisplay.setText(Float.toString(result));
        flA = 0;
        flB = 0;
        a = "0";
        b = "0";
        sauBang = 1;
    }
}