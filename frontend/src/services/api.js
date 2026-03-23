import config from "../config";

const BASE = config.API_BASE_URL;

export const getMedicines = async () => {
  const res = await fetch(`${BASE}/api/medicines`);
  return res.json();
};

export const addMedicine = async (data) => {
  return fetch(`${BASE}/api/medicines`, {
    method: "POST",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify(data)
  });
};

export const recordSale = async (data) => {
  return fetch(`${BASE}/api/medicines/sale`, {
    method: "POST",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify(data)
  });
};
