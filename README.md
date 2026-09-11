# 🎓 IT Elective 2 – Prefinal Examination Dashboard

[![NET Core](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
[![Bootstrap](https://img.shields.io/badge/Bootstrap-5.3-7952B3?logo=bootstrap)](https://getbootstrap.com/)
[![Status](https://img.shields.io/badge/Status-Completed-success)](#)

Isang interactive, modern, at fully responsive na **ASP.NET Core MVC** Web Application na itinayo para sa **IT Elective 2 Prefinal Examination**. Nagpapakita ito ng 20 verified exam questions, verified answers, at dynamic explanations.

---

## 🌟 Key Features

* 🎨 **Modern Glassmorphism UI:** May interactive hero banner, vibrant gradient answer cards, at clean hover transitions.
* 🔍 **Real-Time Live Search:** Mabilis na paghahanap ng tanong o sagot gamit ang keyword search bar.
* 🔘 **Pure JavaScript Filtering:** May instant toggling para sa **All**, **Odd Items**, at **Even Items** nang hindi pinalalabas o nire-refresh ang page.
* 💡 **Collapsible Explanations:** Bawat card ay may independent at interactive accordion button na nagbubukas lamang ng paliwanag para sa napiling item.
* 📱 **Fully Responsive Layout:** Maayos na na-o-optimize sa kahit anong screen size (Desktop, Tablet, o Mobile).

---

## 📁 Project Structure

```text
IT_ELECTIVE_2_SECTION_PREFINAL_EXAM_Lastname_FirstName/
│
├── Controllers/
│   └── HomeController.cs          # Routing at controller logic para sa Index view
│
├── Models/
│   ├── ExamQuestion.cs            # Data model para sa properties ng exam items
│   └── ExamRepository.cs          # In-memory repository na naglalaman ng 20 items
│
├── Views/
│   ├── Home/
│   │   └── Index.cshtml           # Main UI dashboard (Search, Filters, Grid, JS)
│   └── Shared/
│       └── _Layout.cshtml         # Master layout view
│
├── wwwroot/
│   ├── css/
│   │   └── site.css               # Custom styles (Gradients, Glassmorphism, Hover animations)
│   └── js/
│       └── site.js
│
└── Program.cs                     # App configuration at startup entry point
