package com.example.request;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    private EditText editTextLogin;
    private EditText editTextPassword;
    private Button btnLogin;
    private TextView textViewError;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        editTextLogin = findViewById(R.id.editTextLogin);
        editTextPassword = findViewById(R.id.editTextPassword);
        btnLogin = findViewById(R.id.btnLogin);
        textViewError = findViewById(R.id.textViewError);

        btnLogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String login = editTextLogin.getText().toString();
                String password = editTextPassword.getText().toString();

                int userId = authenticateUser(login, password);

                if (userId != -1) {
                    textViewError.setVisibility(View.GONE);
                    Intent intent = new Intent(MainActivity.this, listActivity.class);
                    intent.putExtra("userId", userId);
                    startActivity(intent);
                } else {
                    textViewError.setVisibility(View.VISIBLE);
                }
            }
        });
    }

    private int authenticateUser(String login, String password) {
        for (Data.User user : Data.Users) {
            if (user.Login.equals(login) && user.Password.equals(password)) {
                return user.Id;
            }
        }
        return -1;
    }
}