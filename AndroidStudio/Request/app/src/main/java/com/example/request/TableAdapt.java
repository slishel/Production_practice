package com.example.request;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import java.util.List;

public class TableAdapt extends RecyclerView.Adapter<TableAdapt.RequestViewHolder> {

    private List<Data.Request> requests;
    private Context context;

    public TableAdapt(Context context, List<Data.Request> requests) {
        this.context = context;
        this.requests = requests;
    }

    @NonNull
    @Override
    public RequestViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(context).inflate(R.layout.req_list_item, parent, false);
        return new RequestViewHolder(view);
    }

    @Override
    public void onBindViewHolder(@NonNull RequestViewHolder holder, int position) {
        Data.Request request = requests.get(position);

        holder.textViewRequestId.setText("Номер заявки: " + request.Id);
        holder.textViewCreationDate.setText(request.CreationDate);
        holder.textViewEquipment.setText(request.Equipment);
        holder.textViewFaultType.setText(request.FaultType);
        holder.textViewDescription.setText(request.Description);
        holder.textViewStatus.setText(request.Status);
        holder.textViewDateCompleted.setText(request.DateCompleted != null && !request.DateCompleted.isEmpty() ? request.DateCompleted : "-");
    }

    @Override
    public int getItemCount() {
        return requests.size();
    }

    public static class RequestViewHolder extends RecyclerView.ViewHolder {
        TextView textViewRequestId;
        TextView textViewCreationDate;
        TextView textViewEquipment;
        TextView textViewFaultType;
        TextView textViewDescription;
        TextView textViewStatus;
        TextView textViewDateCompleted;

        public RequestViewHolder(@NonNull View itemView) {
            super(itemView);
            textViewRequestId = itemView.findViewById(R.id.textViewRequestId);
            textViewCreationDate = itemView.findViewById(R.id.textViewCreationDate);
            textViewEquipment = itemView.findViewById(R.id.textViewEquipment);
            textViewFaultType = itemView.findViewById(R.id.textViewFaultType);
            textViewDescription = itemView.findViewById(R.id.textViewDescription);
            textViewStatus = itemView.findViewById(R.id.textViewStatus);
            textViewDateCompleted = itemView.findViewById(R.id.textViewDateCompleted);
        }
    }
}