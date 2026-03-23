# 💊 Pharmacy Management System (SPA)

A full-stack **Single Page Application (SPA)** to manage medicines and sales records, built using **ASP.NET Core Web API** and **React.js**, with lightweight **JSON-based storage**.

---

## 🚀 Features

### 📦 Medicine Management

* Add new medicines
* View medicines in a structured grid
* Store medicine details including:

  * Name
  * Notes
  * Expiry Date
  * Quantity
  * Price
  * Brand

### 🎨 Smart UI Indicators

* 🔴 **Red Highlight** → Medicines expiring within 30 days
* 🟡 **Yellow Highlight** → Low stock (Quantity < 10)

### 🔍 Search Functionality

* Search medicines by name (real-time filtering)

### 🛒 Sales Tracking

* Record medicine sales
* Automatic stock deduction
* Maintain sales history

---

## 🏗️ Tech Stack

| Layer             | Technology           |
| ----------------- | -------------------- |
| Frontend          | React.js             |
| Backend           | ASP.NET Core Web API |
| Storage           | JSON (File-based)    |
| API Communication | REST                 |
| Containerization  | Docker               |

---

## 📁 Project Structure

```
pharmacy-management-system/
│
├── backend/
│   ├── src/PharmacyAPI/
│   │   ├── Controllers/
│   │   ├── Models/
│   │   ├── Services/
│   │   ├── DTOs/
│   │   ├── Middleware/
│   │   ├── Data/
│   │   └── Program.cs
│   │
│   └── tests/
│
├── frontend/
│   ├── src/
│   │   ├── components/
│   │   ├── pages/
│   │   ├── services/
│   │   ├── utils/
│   │   └── styles/
│
└── README.md
```

---

## ⚙️ Setup Instructions

### 🔧 Prerequisites

* .NET SDK (6 or above)
* Node.js (v16+)
* npm

---

## ▶️ Run Backend

```bash
cd backend/src/PharmacyAPI
dotnet run
```

Backend will run at:

```
http://localhost:5000
```

---

## ▶️ Run Frontend

```bash
cd frontend
npm install
npm start
```

Frontend will run at:

```
http://localhost:3000
```

---

## 🔗 Environment Configuration

Create `.env` file in frontend:

```
REACT_APP_API_URL=http://localhost:5000
```

---

## 🔄 API Endpoints

### Medicines

| Method | Endpoint       | Description       |
| ------ | -------------- | ----------------- |
| GET    | /api/medicines | Get all medicines |
| POST   | /api/medicines | Add new medicine  |

### Sales

| Method | Endpoint            | Description   |
| ------ | ------------------- | ------------- |
| POST   | /api/medicines/sale | Record a sale |

---

## 🧪 Sample API Request

### Add Medicine

```json
{
  "fullName": "Paracetamol",
  "notes": "Pain relief",
  "expiryDate": "2026-04-01",
  "quantity": 5,
  "price": 20.5,
  "brand": "ABC Pharma"
}
```

---

## 📊 Business Logic

* Prevents sale if stock is insufficient
* Automatically updates inventory after each sale
* Highlights critical medicines visually (expiry/low stock)

---

## 🐳 Docker Support (Optional)

```bash
docker-compose up --build
```

---

## 📌 Future Enhancements

* JWT Authentication & Role-based access
* Database integration (SQL / MongoDB)
* Pagination & Sorting
* Dashboard with analytics
* AI-based demand prediction
* Cloud deployment (AWS / Azure)

---

## 🧠 Key Learnings

* Full-stack SPA architecture
* REST API design
* File-based persistence
* Component-based frontend design
* Real-time UI updates

---

## 👨‍💻 Author

**Harsh Sonkar**

* Data Engineer | AI/ML Engineer | Full Stack Developer
* Skilled in Python, AWS, React, .NET, and Data Engineering

---

