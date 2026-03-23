export const getRowStyle = (med) => {
  const today = new Date();
  const expiry = new Date(med.expiryDate);
  const diffDays = (expiry - today) / (1000 * 60 * 60 * 24);

  if (diffDays < 30) return { backgroundColor: "red" };
  if (med.quantity < 10) return { backgroundColor: "yellow" };
  return {};
};
