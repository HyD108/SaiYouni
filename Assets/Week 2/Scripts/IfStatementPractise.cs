using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class IfStatementPractise : MonoBehaviour
{
    public int number;
    public float average;
    public int firstNumber;
    public int secondNumber;
    public int money;
    public int price;
    public int year;
    public int age;
    public float averageGrade;
    public int num1;
    public int num2;
    public int num3;
    public int totalTime;
    public int salary;
    public int bonus;
    public bool memberCard;
    public int electricityUsage;
    public int workingYears;
    public bool goodPerformence;
    public int orderValue;
    public float income;
    public float testScore1;
    public float testScore2;
    public float testScore3;
    public int currentStock;
    public int storageCapacity = 100;
    public bool hasCompletedBasicCourse;
    public float finalGrade;             
    public bool hasRecommendationLetter;
    private void Start()
    {
        
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Kiểm tra số dương, âm, hoặc bằng 0
        BaiTap2(); // Kiểm tra số chẵn hay lẻ
        BaiTap3(); // Kiểm tra điều kiện thi đỗ
        BaiTap4(); // Tìm số lớn nhất trong hai số
        BaiTap5(); // Kiểm tra điều kiện mua hàng
        BaiTap6(); // Kiểm tra năm nhuận
        BaiTap7(); // Tính giá vé xem phim
        BaiTap8(); // Kiểm tra học sinh xuất sắc
        BaiTap9(); // So sánh ba số
        BaiTap10(); // Tính tiền lương
        BaiTap11(); // Kiểm tra điều kiện vào câu lạc bộ
        BaiTap12(); // Phân loại học sinh
        BaiTap13(); // Tính tiền điện
        BaiTap14(); // Kiểm tra điều kiện thăng chức
        BaiTap15(); // Kiểm tra điều kiện miễn phí vận chuyển
        BaiTap16(); // Tính thuế thu nhập cá nhân
        BaiTap17(); // Tính điểm trung bình của môn học
        BaiTap18(); // Kiểm tra điều kiện nhập hàng
        BaiTap19(); // Tìm số lớn hơn 10
        BaiTap20(); // Kiểm tra điều kiện đăng ký khóa học
    }

    // Bài Tập 1: Kiểm Tra Số Dương, Âm Hoặc Bằng 0
    void BaiTap1()
    {
        
        if (number > 0)
        {
            Debug.Log("Positive");
        }
        else if (number < 0)
        {
            Debug.Log("Negative");
        }
        else
        {
            Debug.Log("0");
        }
    }

    // Bài Tập 2: Kiểm Tra Số Chẵn Hay Lẻ
    void BaiTap2()
    {
        if (number % 2 == 0)
        {
            Debug.Log("Even Number");
        }
        else
        {
            Debug.Log("Odd Number");
        }

        // Nhập một số từ bàn phím
        // Kiểm tra xem số đó là số chẵn hay lẻ
    }

    // Bài Tập 3: Kiểm Tra Điều Kiện Thi Đỗ
    void BaiTap3()
    {
        if (average >= 5.0f)
        {
            Debug.Log("Pass");
        }
        else
        {
            Debug.Log("Fail");
        }
        // Nhập điểm trung bình của học sinh từ bàn phím
        // Kiểm tra nếu điểm trung bình >= 5.0 thì học sinh đỗ, ngược lại thì trượt
    }

    // Bài Tập 4: Tìm Số Lớn Nhất Trong Hai Số
    void BaiTap4()
    {
        int max = (firstNumber > secondNumber) ? firstNumber : secondNumber;
        Debug.Log("Số lớn nhất: " + max);
        // Nhập hai số nguyên từ bàn phím
        // Kiểm tra và in ra số lớn nhất trong hai số đó
    }

    // Bài Tập 5: Kiểm Tra Điều Kiện Mua Hàng
    void BaiTap5()
    {
        if (money >= price)
        {
            Debug.Log("enough money to buy.");
        }
        else
        {
            Debug.Log("not enough money to buy.");
        }
        // Nhập số tiền hiện có và giá sản phẩm từ bàn phím
        // Kiểm tra xem người dùng có đủ tiền mua hàng không
    }

    // Bài Tập 6: Kiểm Tra Năm Nhuận
    void BaiTap6()
    {
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Debug.Log(year + " leap year");
        }
        else
        {
            Debug.Log(year + " is not lea[ year");
        }
    }
    // Nhập một năm từ bàn phím
    // Kiểm tra xem năm đó có phải là năm nhuận hay không


    // Bài Tập 7: Tính Giá Vé Xem Phim
    void BaiTap7()
    {
        if (age < 18)
        {
            Debug.Log("ticket price: 50000VND");
        }
        else
        {
            Debug.Log("ticket price: 100000VND");
        }
    }

    // Bài Tập 8: Kiểm Tra Học Sinh Xuất Sắc
    void BaiTap8()
    {
        if (averageGrade >= 9.0f)
        {
            Debug.Log("Excellent");
        }
        else
        {
            Debug.Log("is not Excellent");
        }
        // Nhập điểm trung bình của học sinh từ bàn phím
        // Kiểm tra xem học sinh có đạt danh hiệu xuất sắc không (điểm trung bình >= 9.0)
    }

    // Bài Tập 9: So Sánh Ba Số
    void BaiTap9()
    {
        int max = num1;  // Giả sử num1 là số lớn nhất trước tiên

        // So sánh max với num2
        if (num2 > max)
        {
            max = num2;
        }

        // So sánh max hiện tại (sau khi đã so sánh với num2) với num3
        if (num3 > max)
        {
            max = num3;
        }

        // In ra số lớn nhất
        Debug.Log("max: " + max);
    }
    // Nhập ba số nguyên từ bàn phím
    // Kiểm tra và in ra số lớn nhất trong ba số đó


    // Bài Tập 10: Tính Tiền Lương
    void BaiTap10()
    {
        float totalSalary;
        if (totalTime > 40)
        {
            totalSalary = 40 * salary + (totalTime - 40) * bonus;
        }
        else
        {
            totalSalary = totalTime * salary;
        }
        Debug.Log("Salary: " + salary);
        // Nhập số giờ làm việc và mức lương cố định từ bàn phím
        // Nếu nhân viên làm trên 40 giờ, lương được tính thêm giờ
        // Nếu làm dưới hoặc bằng 40 giờ, lương tính theo giờ cố định
    }

    // Bài Tập 11: Kiểm Tra Điều Kiện Vào Câu Lạc Bộ
    void BaiTap11()
    {
        if (age > 18 && memberCard)
        {
            Debug.Log("you can join club");
        }
        else
        {
            Debug.Log("you can not join club");
        }
        // Nhập tuổi và kiểm tra xem người đó có thẻ thành viên hay không
        // Kiểm tra nếu trên 18 tuổi và có thẻ thành viên thì được vào câu lạc bộ
    }

    // Bài Tập 12: Phân Loại Học Sinh
    void BaiTap12()
    {
        if (averageGrade >= 9.0f)
        {
            Debug.Log("Excellent");
        }
        else if (averageGrade >= 7.0f)
        {
            Debug.Log("Good");
        }
        else if (averageGrade >= 5.0f)
        {
            Debug.Log("Normal");
        }
        else
        {
            Debug.Log("Weak");
        }
        // Nhập điểm trung bình của học sinh từ bàn phím
        // Phân loại học sinh theo thang điểm từ xuất sắc đến yếu
    }

    // Bài Tập 13: Tính Tiền Điện
    void BaiTap13()
    {
        float totalBill;
        if (electricityUsage <= 100)
        {
            totalBill = electricityUsage * 1500;
        }
        else
        {
            totalBill = 100 * 1500 + (electricityUsage - 100) * 2000;
        }
        Debug.Log("Total Bill: " + totalBill);
        // Nhập số điện tiêu thụ từ bàn phím
        // Tính tiền điện theo công thức: <= 100 kWh: 1,500 đồng/kWh, >100 kWh: 2,000 đồng/kWh
    }

    // Bài Tập 14: Kiểm Tra Điều Kiện Thăng Chức
    void BaiTap14()
    {
        if (workingYears > 5 && goodPerformence)
        {
            Debug.Log("you are promoted.");
        }
        else
        {
            Debug.Log("you are not promoted.");
        }
        // Nhập số năm làm việc và đánh giá công việc
        // Kiểm tra nếu số năm làm việc trên 5 năm và đánh giá tốt thì đủ điều kiện thăng chức
    }

    // Bài Tập 15: Kiểm Tra Điều Kiện Miễn Phí Vận Chuyển
    void BaiTap15()
    {
        if (orderValue >= 500000)
        {
            Debug.Log("FreeShip.");
        }
        else
        {
            Debug.Log("is not FreeShip.");
        }
        // Nhập giá trị đơn hàng từ bàn phím
        // Kiểm tra nếu giá trị đơn hàng >= 500,000 đồng thì được miễn phí vận chuyển
    }

    // Bài Tập 16: Tính Thuế Thu Nhập Cá Nhân
    void BaiTap16()
    {
        static float CalculateTax(float income)
        {
            float taxRate;
            if (income <= 5000000)
            {
                taxRate = 0.05f; // 5%
            }
            else if (income <= 10000000)
            {
                taxRate = 0.1f; // 10%
            }
            else if (income <= 18000000)
            {
                taxRate = 0.15f; // 15%
            }
            else
            {
                taxRate = 0.2f; // 20%
            }
            return income * taxRate;
        }
        float taxAmount = CalculateTax(income);
        Debug.Log($"money needing to pay for tax: {taxAmount} VND");
        // Nhập thu nhập từ bàn phím
        // Tính thuế thu nhập cá nhân dựa trên mức thu nhập
    }

    // Bài Tập 17: Tính Điểm Trung Bình Của Môn Học
    void BaiTap17()
    {
        float averageScore = (testScore1 + testScore2 + testScore3) / 3.0f;
        Debug.Log($"Average Score: {averageScore}");

        // Kiểm tra xem học sinh có đạt yêu cầu không (điểm trung bình >= 5.0)
        if (averageScore >= 5.0f)
        {
            Debug.Log("Enough.");
        }
        else
        {
            Debug.Log("Not Enough.");
        }
        // Nhập điểm của 3 bài kiểm tra từ bàn phím
        // Tính điểm trung bình và kiểm tra xem học sinh có đạt yêu cầu hay không (>= 5.0)
    }

    // Bài Tập 18: Kiểm Tra Điều Kiện Nhập Hàng
    void BaiTap18()
    {
        if (currentStock < storageCapacity)
        {
            int spaceAvailable = storageCapacity - currentStock;
            Debug.Log($"you can import maximum {spaceAvailable}.");
        }
        else
        {
            Debug.Log("StorageCapacity is full");
            // Nhập số lượng hàng hiện tại và kiểm tra khả năng nhập thêm hàng (dưới 100 và còn chỗ)
        }
    }

    // Bài Tập 19: Tìm Số Lớn Hơn 10
    void BaiTap19()
    {
        if (number > 10)
        {
            Debug.Log(number + " > 10");
        }
        else
        {
            Debug.Log(number + " < 10>");
            // Nhập một số từ bàn phím
            // Kiểm tra xem số đó có lớn hơn 10 hay không
        }
    }
    // Bài Tập 20: Kiểm Tra Điều Kiện Đăng Ký Khóa Học
    void BaiTap20()
    {
        if (hasCompletedBasicCourse && finalGrade >= 7.0f && hasRecommendationLetter)
        {
            Debug.Log("Can register advance course.");
        }
        else
        {
            Debug.Log("Can not register advance course.");
        }
        // Nhập điểm tổng kết và các điều kiện khác từ bàn phím
        // Kiểm tra xem học sinh có đủ điều kiện đăng ký khóa học nâng cao không
    }
}
