import React from "react";

const SearchBar = ({ search, setSearch }) => {
  return (
    <input
      placeholder="Search medicine..."
      value={search}
      onChange={(e) => setSearch(e.target.value)}
      style={{ marginBottom: "10px", padding: "8px", width: "300px" }}
    />
  );
};

export default SearchBar;
