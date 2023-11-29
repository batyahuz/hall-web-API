# web-api-hall
הקמת פרויקט צד שרת של אולם

**מערכת ניהול אולם**
תאור הפרויקט:
.מערכת לניהול ארועים באולם
, באמצעות המערכת ניתן להזמין תאריך לאירוע ולנהל את כלל האירועים באולם.
**:ישויות**
  1. לקוח
  2. קיטרינג
  3. ארוע
  מיפוי Routes ללקוח
  - שליפת רשימת הלקוחות
GET   https://golden_hall.co.il/customers
   -שליפת לקוח לפי מספר טלפון 
GET  https://golden_hall.co.il/customers/phonenum
-הוספת לקוח
POST  https://golden_hall.co.il/customers
-עדכון לקוח לפי מספר טלפון
PUT  https://golden_hall.co.il/customers/phonenum

לקיטרינג Routs מיפוי 
  -שליפת רשימת הקיטרינגים
GET   https://golden_hall.co.il/caterings
   -שליפת קיטרינג ע"פ מזהה
GET  https://golden_hall.co.il/caterings/id
 - הוספת קיטרינג
POST  https://golden_hall.co.il/caterings
   -עדכון קיטרינג ע"פ מזהה
GET  https://golden_hall.co.il/caterings/id
 - מחיקת קייטרינג ע"פ מזהה
DELETE  https://golden_hall.co.il/caterings/id
לארוע Routs מיפוי 
  -שליפת רשימת הארועים
GET  https://golden_hall.co.il/events
   -שליפת ארוע ע"פ מזהה
GET  https://golden_hall.co.il/events/id
 - הוספת ארוע
POST  https://golden_hall.co.il/events
-עדכון ארוע לפי מזהה
PUT  https://golden_hall.co.il/events/id
 מחיקת ארוע לפי מזהה
DELETE  https://golden_hall.co.il/events/id
בחרתי לא למפות ROUTS ללקוח כיון שאני רוצה שישארו לי כל רשימת הלקוחות בארכיון
במקום זה אוסיף ROUTS לעדכון סטטוס לFALSE אם הלקוח לא הזמין יותר משנה.
PUT  https://customers/phonenum/status
