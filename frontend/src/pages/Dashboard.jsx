import React, { useEffect, useState } from "react";
import { getMedicines } from "../services/api";
import MedicineTable from "../components/MedicineTable";
import MedicineForm from "../components/MedicineForm";
import SearchBar from "../components/SearchBar";

const Dashboard = () => {
  const [medicines, setMedicines] = useState([]);
  const [search, setSearch] = useState("");

  const fetchData = async () => {
    const data = await getMedicines();
    setMedicines(data);
  };

  useEffect(() => {
    fetchData();
  }, []);

  const filtered = medicines.filter((m) =>
    m.fullName.toLowerCase().includes(search.toLowerCase())
  );

  return (
    <div>
      <h2>Pharmacy Dashboard</h2>

      <SearchBar search={search} setSearch={setSearch} />
      <MedicineForm refresh={fetchData} />
      <MedicineTable medicines={filtered} />
    </div>
  );
};

export default Dashboard;
