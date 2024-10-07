using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ForeachPractise : MonoBehaviour
{
    public int[] numbers;
    public List<int> list = new List<int>();
    // Start is called before the first frame update
    void Start()
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
        foreach (int i in numbers)
        {
            Debug.Log(i);
        }
        // Tạo một mảng số nguyên
        // Sử dụng foreach để in tất cả các phần tử trong mảng
    }

    // Bài Tập 2: Tính Tổng Các Phần Tử Trong Mảng
    void BaiTap2() {
    int sum = 0;
        foreach (int i in numbers)
        {
            sum += i;
        }
        Debug.Log(sum);
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tính tổng tất cả các phần tử trong mảng
    }

    // Bài Tập 3: Tìm Phần Tử Lớn Nhất Trong Mảng
    void BaiTap3()
    {
        int max = numbers[0];
        foreach (int i in numbers)
        {
            if(i > max)
            {
                max = i;
            }
        }
        Debug.Log(max);
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tìm phần tử lớn nhất trong mảng
    }

    // Bài Tập 4: Đếm Số Lượng Số Chẵn Trong Mảng
    void BaiTap4()
    {
        int count = 0;
        foreach (int i in numbers)
        {
            if(i % 2 == 0)
            {
                count++;
            }
        }
        Debug.Log(count);
        // Tạo một mảng số nguyên
        // Sử dụng foreach để đếm số lượng phần tử chẵn trong mảng
    }

    // Bài Tập 5: In Tất Cả Các Chuỗi Trong Danh Sách
    void BaiTap5()
    {
        List<string> list = new List<string>();
        list.Add("Sai");
        list.Add("Youni");
        list.Add("Course");

        foreach (string name in list)
        {
            Debug.Log(name);
        }
        Debug.Log("========================================");
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để in tất cả các chuỗi trong danh sách
    }

    // Bài Tập 6: Tìm Chuỗi Dài Nhất Trong Danh Sách
    void BaiTap6()
    {
        List<string> list = new List<string>();
        list.Add("Sai");
        list.Add("Youni");
        list.Add("Course");

        string longestString = list[0];

        foreach (string name in list)
        {
            if (name.Length > longestString.Length)
                longestString = name;
        }
        Debug.Log(longestString);
        Debug.Log("========================================");
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để tìm chuỗi dài nhất trong danh sách
    }

    // Bài Tập 7: Tính Tổng Các Số Lẻ Trong Mảng
    void BaiTap7()
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                sum += number;
            }
        }
        Debug.Log(sum);
        Debug.Log("========================================");

        // Tạo một mảng số nguyên
        // Sử dụng foreach để tính tổng tất cả các số lẻ trong mảng
    }

    // Bài Tập 8: In Các Số Chẵn Trong Mảng
    void BaiTap8()
    {
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                Debug.Log(number);
            }
        }
        Debug.Log("========================================");
        // Tạo một mảng số nguyên
        // Sử dụng foreach để in tất cả các số chẵn trong mảng
    }

    // Bài Tập 9: Kiểm Tra Sự Tồn Tại Của Một Phần Tử Trong Mảng
    void BaiTap9()
    {
        int check = 7;
        foreach (int number in numbers)
        {
            if (number == check)
            {
                Debug.Log("Checked Number exist in Array");
            }
        }
        Debug.Log("========================================");
        // Tạo một mảng số nguyên và một phần tử cần kiểm tra
        // Sử dụng foreach để kiểm tra xem phần tử đó có tồn tại trong mảng không
    }

    // Bài Tập 10: Đếm Số Phần Tử Âm Trong Mảng
    void BaiTap10()
    {
        int count = 0;
        foreach (int number in numbers)
        {
            if (number < 0)
            {
                count++;
            }
        }
        Debug.Log(count);
        Debug.Log("========================================");
        // Tạo một mảng số nguyên
        // Sử dụng foreach để đếm số lượng các phần tử âm trong mảng
    }

    // Bài Tập 11: In Các Số Lớn Hơn 10 Trong Mảng
    void BaiTap11()
    {
        foreach (int number in numbers)
        {
            if (number > 10)
            {
                Debug.Log(number);
            }
        }
        Debug.Log("========================================");
        // Tạo một mảng số nguyên
        // Sử dụng foreach để in các số lớn hơn 10 trong mảng
    }

    // Bài Tập 12: Tìm Chuỗi Có Độ Dài Ngắn Nhất Trong Danh Sách
    void BaiTap12()
    {
        List<string> list = new List<string>();
        list.Add("Sai");
        list.Add("Youni");
        list.Add("Course");
        string shortestString = list[0];
        foreach (string s in list)
        {
            if (s.Length < shortestString.Length)
            {
                shortestString = s;
            }
        }
        Debug.Log(shortestString);
        Debug.Log("========================================");
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để tìm chuỗi có độ dài ngắn nhất trong danh sách
    }

    // Bài Tập 13: Nhân Đôi Tất Cả Các Phần Tử Trong Mảng
    void BaiTap13()
    {
        foreach (int number in numbers)
        {
            Debug.Log(number * 2);
        }
        Debug.Log("========================================");
        // Tạo một mảng số nguyên
        // Sử dụng foreach để nhân đôi tất cả các phần tử trong mảng
    }

    // Bài Tập 14: Tìm Số Lớn Thứ Hai Trong Mảng
    void BaiTap14()
    {
        int max = numbers[0];
        int secondLargest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                secondLargest = max;
                max = number;
            }
            else if (number > secondLargest && number != max)
            {
                secondLargest = number;
            }
        }
        Debug.Log(secondLargest);
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tìm phần tử lớn thứ hai trong mảng
    }

    // Bài Tập 15: Tìm Chuỗi Bắt Đầu Bằng Chữ Cái A
    void BaiTap15()
    {
        List<string> list = new List<string>();
        list.Add("Sai");
        list.Add("Youni");
        list.Add("Course");
        list.Add("Advance");

        foreach (string s in list)
        {
            if (s.StartsWith("A"))
            {
                Debug.Log(s);
            }
        }
        Debug.Log("========================================");
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để tìm và in các chuỗi bắt đầu bằng chữ cái 'A'
    }

    // Bài Tập 16: Kiểm Tra Xem Danh Sách Có Chứa Một Chuỗi Cụ Thể Không
    void BaiTap16()
    {
        List<string> list = new List<string>();
        list.Add("Sai");
        list.Add("Youni");
        list.Add("Course");
        list.Add("Advance");

        bool check = false;
        foreach (string s in list)
        {
            if (s == "Hello")
            {
                check = true;
                break;
            }
        }
        if (check) Debug.Log("Yes");
        else Debug.Log("False");
        Debug.Log("========================================");
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để kiểm tra xem danh sách có chứa chuỗi "Hello" hay không
    }

    // Bài Tập 17: In Tất Cả Các Phần Tử Âm Trong Mảng
    void BaiTap17()
    {
        foreach (int number in numbers)
        {
            if (number < 0)
            {
                Debug.Log(number);
            }
        }
        Debug.Log("========================================");
        // Tạo một mảng số nguyên
        // Sử dụng foreach để in ra tất cả các phần tử âm trong mảng
    }

    // Bài Tập 18: Đếm Số Lần Xuất Hiện Của Một Phần Tử Trong Mảng
    void BaiTap18()
    {
        int checkedNumber = 4;
        int count = 0;
        foreach (int number in numbers)
        {
            if (number == checkedNumber)
            {
                count++;
            }
        }
        Debug.Log(count);
        Debug.Log("========================================");

        // Tạo một mảng số nguyên và một phần tử cụ thể
        // Sử dụng foreach để đếm số lần xuất hiện của phần tử cụ thể đó trong mảng
    }

    // Bài Tập 19: Tạo Một Danh Sách Mới Từ Các Phần Tử Lớn Hơn 10 Trong Mảng
    void BaiTap19()
    {
        foreach (int number in numbers)
        {
            if (number > 10)
            {
                list.Add(number);
            }
        }
        foreach (int number in list)
        {
            Debug.Log(number);
        }

        Debug.Log("========================================");
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tạo một danh sách mới chứa các phần tử có giá trị lớn hơn 10
    }

    // Bài Tập 20: In Các Chuỗi Có Độ Dài Lớn Hơn 5 Ký Tự
    void BaiTap20()
    {
        List<string> list = new List<string>();
        list.Add("Sai");
        list.Add("Youni");
        list.Add("Course");
        list.Add("Advance");

        foreach (string s in list)
        {
            if (s.Length > 5)
            {
                Debug.Log(s);
            }
        }
        Debug.Log("========================================");
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để in các chuỗi có độ dài lớn hơn 5 ký tự
    }

}
