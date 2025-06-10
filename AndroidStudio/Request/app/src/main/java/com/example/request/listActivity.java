package com.example.request;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;

import java.util.ArrayList;
import java.util.List;

public class listActivity extends AppCompatActivity {

    private RecyclerView recyclerViewReq;
    private TableAdapt tableAdapt;
    private Button btnBack;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_list);

        recyclerViewReq = findViewById(R.id.recyclerViewReq);
        btnBack = findViewById(R.id.btnBack);

        int userId = getIntent().getIntExtra("userId", -1);

        List<Data.Request> userRequests = getUserRequests(userId);

        recyclerViewReq.setLayoutManager(new LinearLayoutManager(this));
        tableAdapt = new TableAdapt(this, userRequests);
        recyclerViewReq.setAdapter(tableAdapt);

        btnBack.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish();
            }
        });
    }

    private List<Data.Request> getUserRequests(int userId) {
        List<Data.Request> userRequests = new ArrayList<>();
        for (Data.Request request : Data.Requests) {
            if (request.ClientId == userId) {
                userRequests.add(request);
            }
        }
        return userRequests;
    }
}