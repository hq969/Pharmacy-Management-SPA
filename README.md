# 💊 Pharmacy Management SPA

A lightweight **Single Page Application (SPA)** built using **.NET Core Web API and JavaScript** to manage pharmacy inventory, track medicines, and monitor expiry status efficiently.

---

## 🚀 Features

* 📋 View all medicines in a structured grid
* ➕ Add new medicine records
* 🔍 Search medicines by name *(real-time filtering)*
* ⚠️ Smart visual indicators:

  * 🔴 **Red** → Expiry date less than 30 days
  * 🟡 **Yellow** → Quantity less than 10
* 💾 Persistent storage using JSON file
* ⚡ Fast and simple SPA (no page reload)

---

## 🏗️ Tech Stack

| Layer        | Technology            |
| ------------ | --------------------- |
| Backend      | .NET Core Web API     |
| Frontend     | HTML, CSS, JavaScript |
| Storage      | JSON File (data.json) |
| Architecture | REST API + SPA        |

---

## 📂 Project Structure

```
Pharmacy-Management-SPA/
│
├── backend/PharmacyApi/
│   ├── Controllers/
│   ├── Models/
│   ├── Services/
│   ├── wwwroot/
│   ├── Program.cs
│   └── data.json
│
├── docs/
├── frontend/ (optional)
└── README.md
```

---

## ⚙️ Installation & Setup

### 1️⃣ Clone Repository

```bash
git clone https://github.com/hq969/Pharmacy-Management-SPA.git
cd Pharmacy-Management-SPA/backend/PharmacyApi
```

### 2️⃣ Run Application

```bash
dotnet run
```

### 3️⃣ Open in Browser

```
https://localhost:<port>/index.html
```

---

## 📡 API Endpoints

| Method | Endpoint      | Description         |
| ------ | ------------- | ------------------- |
| GET    | /api/medicine | Fetch all medicines |
| POST   | /api/medicine | Add new medicine    |

---

## 🧠 Business Logic

* Expiry Alert:

  * Medicines expiring within **30 days** are highlighted in **red**
* Low Stock Alert:

  * Medicines with **quantity < 10** are highlighted in **yellow**
* Price formatting:

  * Always stored and displayed with **2 decimal precision**

---

## 📸 Screenshots

> Add screenshots of UI here for better presentation

---

## 🔮 Future Enhancements

* 🧾 Sales & Billing Module
* 🗄️ Database Integration (SQL Server / PostgreSQL)
* 🔐 Authentication & Authorization (JWT)
* ⚛️ React Frontend Upgrade
* ☁️ Cloud Deployment (AWS / Azure)
* 🤖 AI-based Demand Prediction

---

## 👨‍💻 Author

**Harsh Sonkar**
AI Engineer | Data Engineer | Full Stack Developer

---

## 📜 License

This project is licensed under the MIT License.

---

