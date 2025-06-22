# 💌 IdentityChatEmail (.NET Core 8.0)

**IdentityChatEmail** is an email messaging application developed under **M&Y Yazılım Eğitim Akademi Danışmanlık** (a software training and consultancy company) and guided by our esteemed instructor **Murat Yücedağ**, fully completing all cases; it is built on **ASP.NET Core 8.0** and integrated with the **Identity** system. 

After registering and logging into the system, users can:

- ✉️ Send and receive messages,  
- 📥 View inbox and 📤 sent message folders,  
- 🛠️ Easily manage their profile information.

---

## 🎯 Project Purpose

This project demonstrates a basic messaging system built using *ASP.NET Core Identity* and *Entity Framework Core*.  

**Goals:**  
- To provide secure user registration and login processes  
- To offer a functional messaging experience with a simple, modern, and user-friendly interface  

---

## ⚒️ Technologies Used

- 💎 ASP.NET Core MVC  
- 💎 Entity Framework Core  
- 💎 ASP.NET Core Identity  
- 💎 MS SQL Server  
- 💎 SweetAlert2  

---

## 🚀 Features

- 👤 User registration, login, and logout  
- ✉️ Compose and send new messages  
- 📥 Inbox for received messages  
- 📤 Sent items folder  
- 🗑️ Move messages to trash  
- 🛠️ Update profile information  
- ✅ Success notifications via SweetAlert2  
- 📊 Responsive and modern design based on Bootstrap  

---

## 📃 Page Structure

### 👤 Register Page  
📲 Users register here; information is stored in the database.  
🔐 Passwords are stored securely using hashing.  
❌ Password rules are validated.  
![Register Page](https://github.com/user-attachments/assets/fbae2c7b-e6dc-4fd7-a090-0d3028dbb6e6)

---

### 🔑 Login Page  
👤 Users log in with their credentials.  
🚫 After 5 failed attempts, login is locked for 5 minutes.  
![Login Page](https://github.com/user-attachments/assets/7f59a4b8-ce0d-4eca-aa1f-b48650ca7758)

---

### 💠 Profile Page  
📝 Displays user’s name, surname, email, and profile picture.  
📊 Shows sent and received message counts dynamically.  
🛠️ Allows updating user information.  
![Profile Page](https://github.com/user-attachments/assets/cd0f8fb2-90e5-42ce-9a7c-8b81a437944d)

---

### 🆕 Create New User  
🧑 Users can create a new account via the registration form.  
📝 Required fields: username, name, surname, email, and password.  
🔍 System validates inputs and shows errors if any.  
✅ On success, user is created and redirected to the profile page.  
![Create User](https://github.com/user-attachments/assets/cd4fc5c6-18ff-4cb6-84e2-367608f71740)

---

### 📥 Inbox & 📤 Sent Items  
📬 Users can view their received and sent messages.  
🔎 Messages can be filtered using the search bar.  
🔄 Messages can be moved to the trash folder.  
🔢 Message counts update dynamically in the sidebar.  
![Inbox](https://github.com/user-attachments/assets/59f6b514-1d9d-4e74-b0c8-15f8ed906b7e)  
![Sent Items](https://github.com/user-attachments/assets/fba392c6-8e9b-47de-a862-5af23cbe9f4c)  
![Message Details](https://github.com/user-attachments/assets/f1327df5-428e-4069-a1cb-bf03d4fc5bba)  
![Sidebar](https://github.com/user-attachments/assets/453b5724-7e96-4d5d-8f94-ba843438e77f)

---

### 📨 Compose New Message  
📧 Users enter recipient email, subject, and message content.  
✅ SweetAlert notification confirms successful sending.  
![New Message](https://github.com/user-attachments/assets/4bc3fb37-8460-4eaf-b465-fb73db916820)  
![SweetAlert](https://github.com/user-attachments/assets/b13c58ae-c4ce-4cee-97f2-13afd602d94f)
