<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="meat3.aspx.cs" Inherits="meat.meat3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Umai屋馬燒肉</title>
    <link rel="icon" href="images/333.jpg" type="images/333.jpg"/>
    <link href="style.css" type="text/css" rel="stylesheet"/>
</head>
<body style="background-color:#ffffff">
   
  
    
        <div class="container">
      <img src="images/333.png" width="70"/>
            <nav>
      <ul>
        <li>
          <a href="https://localhost:44381/meat.aspx">首頁</a>
        </li>
        <li>
          <a href="#">食材配送</a>
        </li>
        <li>
          <a href="https://localhost:44381/meat3.aspx">線上訂位</a>
        </li>
          <li>
          <a href="#">最新消息</a>
        </li>
          <li>
          <a href="https://localhost:44381/meat2.aspx">屋馬菜單</a>
        </li>
          <li>
          <a href="#">常見問題</a>
        </li>
          
      </ul>
    </nav>
  </div>

  
      
            <div class="rbbb">
            
         
                </div>
    <div>
        <h1>選擇訂位時段</h1>
        姓名:<input type="text" name="user"/><br/>
        連絡電話:<input type="text" name="user"/><br/>
        用餐人數<select name="peopleType">
            <option value="1位">一位大人</option>
            <option value="2位">二位大人</option>
            <option value="3位">三位大人</option>
            <option value="4位">四位大人</option>
            <option value="5位">五位大人</option>
            <option value="6位">六位大人</option>
            <option value="7位">七位大人</option>
            <option value="8位">八位大人</option>
            <option value="9位">九位大人</option>
            <option value="10位">十位大人</option>
            </select>
  <select>
            <option value="0位">零位小孩</option>
            <option value="1位">一位小孩</option>
            <option value="2位">二位小孩</option>
            <option value="3位">三位小孩</option>
            <option value="4位">四位小孩</option>
            <option value="5位">五位小孩</option>
            <option value="6位">六位小孩</option>
            <option value="7位">七位小孩</option>
            <option value="8位">八位小孩</option>

  </select>
         選擇分店:<select name="shopType">
            <option value="店">文心店</option>
            <option value="店">園邸店</option>
            <option value="店">中港店</option>
            <option value="店">國安店</option>
            <option value="店">崇德店</option>
            <option value="店">中友店</option>
            <option value="店">文心秀泰店</option>

            </select>
        <label for="start">用餐日期:</label>

        <input type="date" id="start" name="trip-start"
            value="2022-12-11"
            min="2022-01-01" max="2022-12-31" />
        
        
         
    </div>
    <input type="submit" value="完成" />
            </body>
</html>
