import React from "react";
import { getRowStyle } from "../utils/helpers";

const MedicineTable = ({ medicines }) => {
  return (
    <table border="1" cellPadding="10">
      <thead>
        <tr>
          <th>Name</th>
          <th>Expiry</th>
          <th>Quantity</th>
          <th>Price</th>
          <th>Brand</th>
        </tr>
      </thead>
      <tbody>
        {medicines.map((m) => (
          <tr key={m.id} style={getRowStyle(m)}>
            <td>{m.fullName}</td>
            <td>{new Date(m.expiryDate).toLocaleDateString()}</td>
            <td>{m.quantity}</td>
            <td>{m.price}</td>
            <td>{m.brand}</td>
          </tr>
        ))}
      </tbody>
    </table>
  );
};

export default MedicineTable;
