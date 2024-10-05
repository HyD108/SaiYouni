using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ForPractise : MonoBehaviour
{
    public int[] numbers;
    public int input;
    private void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // In tất cả các phần tử trong mảng
        BaiTap2(); // Tính tổng các phần tử trong mảng
        BaiTap3(); // Tìm phần tử lớn nhất trong mảng
        BaiTap4(); // Đếm số lượng số chẵn trong mảng
        BaiTap5(); // In tất cả các chuỗi trong danh sách
        BaiTap6(); // Tìm chuỗi dài nhất trong danh sách
        BaiTap7(); // Tính tổng các số lẻ trong mảng
        BaiTap8(); // In các số chẵn trong mảng
        BaiTap9(); // Kiểm tra sự tồn tại của một phần tử trong mảng
        BaiTap10(); // Đếm số phần tử âm trong mảng
        BaiTap11(); // In các số lớn hơn 10 trong mảng
        BaiTap12(); // Tìm chuỗi có độ dài ngắn nhất trong danh sách
        BaiTap13(); // Nhân đôi tất cả các phần tử trong mảng
        BaiTap14(); // Tìm số lớn thứ hai trong mảng
        BaiTap15(); // Tìm chuỗi bắt đầu bằng chữ cái A
        BaiTap16(); // Kiểm tra danh sách có chứa chuỗi "Hello" không
        BaiTap17(); // In tất cả các phần tử âm trong mảng
        BaiTap18(); // Đếm số lần xuất hiện của một phần tử trong mảng
        BaiTap19(); // Tạo danh sách mới từ các phần tử lớn hơn 10
        BaiTap20(); // In các chuỗi có độ dài lớn hơn 5 ký tự
    }

    // Bài Tập 1: In Tất Cả Các Phần Tử Trong Mảng
    void BaiTap1()
    {
        for ( int i = 1; i <= 100; i++)
        {
            Debug.Log(i);
        }
    }

    // Bài Tập 2: Tính Tổng Các Phần Tử Trong Mảng
    void BaiTap2()
    {
        int sum = 0;    
        for( int i = 1;i <= 50; i++)
        {
            sum += i;
            Debug.Log(sum);
        }
        Debug.Log(sum);
    }

    // Bài Tập 3: Tìm Phần Tử Lớn Nhất Trong Mảng
    void BaiTap3()
    {
        for( int i = 1; i <= 100; i++)
        {
            if(i % 2 == 0)
            {
                Debug.Log(i);
            }
        }
    }

    // Bài Tập 4: Đếm Số Lượng Số Chẵn Trong Mảng
    void BaiTap4()
    {
        int mul = 1;
        for( int i = 1;i <= 10; i++)
        {
            mul *= i;
        }
        Debug.Log(mul);
    }

    // Bài Tập 5: In Tất Cả Các Chuỗi Trong Danh Sách
    void BaiTap5()
    {
        int max = numbers[0];
        for( int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        Debug.Log(max);
    }

    // Bài Tập 6: Tìm Chuỗi Dài Nhất Trong Danh Sách
    void BaiTap6()
    {
        int sum = 0;    
        for ( int i = 1;i < 100; i++)
        {
            if(i % 2 != 0)
            {
                sum += i;
            }
        }
        Debug.Log(sum);
    }

    // Bài Tập 7: Tính Tổng Các Số Lẻ Trong Mảng
    void BaiTap7()
    {
        string firstString = "Sai Youni Course";
        string reverseString = "";
        for (int i = firstString.Length - 1; i >= 0; i--)
        {
            reverseString += firstString[i];
        }
        Debug.Log(reverseString);

    }

    // Bài Tập 8: In Các Số Chẵn Trong Mảng
    void BaiTap8()
    {
        int number = 3;
        for (int i = 0; i <= 10; i++)
        {
           Debug.Log(number + "x" + i + "=" + (number * i)); 
        }
    }

    // Bài Tập 9: Kiểm Tra Sự Tồn Tại Của Một Phần Tử Trong Mảng
    void BaiTap9()
    {
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                count++;
            }
        }
        Debug.Log(count);
    }

    // Bài Tập 10: Đếm Số Phần Tử Âm Trong Mảng
    void BaiTap10()
    {
        for (int i = 1; i <= 5; i++) 
        {
            for (int j = 1; j <= i; j++) 
            {             
                Debug.Log(j);
            }
            Debug.Log(""); 
        }
    }

    // Bài Tập 11: In Các Số Lớn Hơn 10 Trong Mảng
    void BaiTap11()
    {
        int min = numbers[0];
        for (int i = 0; i < numbers.Length; i++ ) 
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        Debug.Log(min);
    }

    // Bài Tập 12: Tìm Chuỗi Có Độ Dài Ngắn Nhất Trong Danh Sách
    void BaiTap12()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để tìm chuỗi có độ dài ngắn nhất trong danh sách
    }

    // Bài Tập 13: Nhân Đôi Tất Cả Các Phần Tử Trong Mảng
    void BaiTap13()
    {
        int number = 1;
        for(int i = 1; i <= 4; i++)
        {
            number *= i;
        }
        Debug.Log(number);
    }

    // Bài Tập 14: Tìm Số Lớn Thứ Hai Trong Mảng
    void BaiTap14()
    {
        for (int i = input; i <= 1; i--)
        {
            Debug.Log(i);
        }
    }

    // Bài Tập 15: Tìm Chuỗi Bắt Đầu Bằng Chữ Cái A
    void BaiTap15()
    {
       int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Debug.Log(sum);
    }

    // Bài Tập 16: Kiểm Tra Xem Danh Sách Có Chứa Một Chuỗi Cụ Thể Không
    void BaiTap16()
    {
        int n = 5;
        bool isPrime = true;
        for (int i = 1; i <= Mathf.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                isPrime = false;               
            }
            else
            {
                isPrime = true;            
            }
        }
        if (isPrime)
        {
            Debug.Log("5 is Prime");
        }else
        {
            Debug.Log("5 is not prime");
        }

    }

    // Bài Tập 17: In Tất Cả Các Phần Tử Âm Trong Mảng
    void BaiTap17()
    {
        for (int i = 1; i <= 100; i++)
        {
            if(i % 3 == 0)
            {
                Debug.Log(i);
            }
        }

    }

    // Bài Tập 18: Đếm Số Lần Xuất Hiện Của Một Phần Tử Trong Mảng
    void BaiTap18()
    {
        int sum = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }           
        }
        Debug.Log(sum);
    }

    // Bài Tập 19: Tạo Một Danh Sách Mới Từ Các Phần Tử Lớn Hơn 10 Trong Mảng
    void BaiTap19()
    {
        int sum = 0;
        int avr;
        for (int i = 0;i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        avr = sum / numbers.Length;
        Debug.Log(avr); 
    }

    // Bài Tập 20: In Các Chuỗi Có Độ Dài Lớn Hơn 5 Ký Tự
    void BaiTap20()
    {
        string firstString = "Sai Youni Course";
        int count = 0;  
        for (int i = 0; i < firstString.Length; i++)
        {
            if (char.IsUpper(firstString[i]))
            {
                count++;
            }
        }
        Debug.Log(count);
    }
}
