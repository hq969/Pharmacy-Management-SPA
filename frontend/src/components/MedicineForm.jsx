import React, { useState } from "react";
import { addMedicine } from "../services/api";

const MedicineForm = ({ refresh }) => {
  const [form, setForm] = useState({
    fullName: "",
    notes: "",
    expiryDate: "",
    quantity: "",
    price: "",
    brand: ""
  });

  const handleChange = (e) => {
    setForm({ ...form, [e.target.name]: e.target.value });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    await addMedicine(form);
    refresh();
  };

  return (
    <form onSubmit={handleSubmit}>
      <h3>Add Medicine</h3>

      <input name="fullName" placeholder="Name" onChange={handleChange} required />
      <input name="notes" placeholder="Notes" onChange={handleChange} />
      <input name="expiryDate" type="date" onChange={handleChange} required />
      <input name="quantity" type="number" placeholder="Quantity" onChange={handleChange} required />
      <input name="price" type="number" step="0.01" placeholder="Price" onChange={handleChange} required />
      <input name="brand" placeholder="Brand" onChange={handleChange} required />

      <button type="submit">Add</button>
    </form>
  );
};

export default MedicineForm;
