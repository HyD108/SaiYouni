# Agenda Phát Triển Game Week 3

## 1. Tìm Thêm 5 Characters Cho Game

- Nghiên cứu và chọn 5 nhân vật mới để thêm vào game.
- Tìm kiếm các nhân vật có phong cách và khả năng phù hợp với lối chơi của game.
- Đảm bảo rằng các nhân vật này được tối ưu hóa cho hiệu suất.

## 2. Gắn Animation Chạy (Run) Vào Cho 5 Characters Mới

- Gắn animation chạy mặc định vào từng nhân vật mới.
- Kiểm tra xem các animation có tương thích và hoạt động mượt mà trên các nhân vật.

## 3. Lần Lượt Gắn 3 Animation Chạy Khác Nhau Vào Animator

- Gắn ba animation chạy khác nhau vào hệ thống Animator của Unity.
- Thiết lập các transition (chuyển cảnh) giữa các animation để tạo sự linh hoạt cho các hành động của nhân vật.
- Kiểm tra tính đồng nhất giữa các animation trong quá trình chuyển tiếp.

## 4. Tìm Kiếm 2 Website Khác Ngoài Unity Store Cung Cấp Asset

1. Free3D:Free3D là một nền tảng cung cấp tài nguyên 3D miễn phí và trả phí, bao gồm các mô hình nhân vật, môi trường, phương tiện, và nhiều loại khác. Mặc dù không chỉ dành riêng cho Unity, nhiều mô hình trên trang web được cung cấp dưới dạng tệp .FBX, .OBJ, và .3DS, dễ dàng tích hợp vào Unity.
2. ArtStation: rtStation là một nền tảng nổi tiếng, chủ yếu để các nghệ sĩ trưng bày các danh mục đầu tư của họ, nhưng cũng có một chợ trực tuyến cung cấp tài nguyên 3D, với nhiều mục được tối ưu hóa cho phát triển game. ArtStation cung cấp các mô hình chất lượng cao, thường được tạo bởi các nghệ sĩ chuyên nghiệp trong ngành game và phim ảnh.
- Tìm và đánh giá thêm 2 trang web cung cấp asset để làm phong phú nguồn tài nguyên cho dự án.
- Một số trang web có thể tham khảo bao gồm:
  - **CGTrader**: Chuyên cung cấp asset 3D.
  - **TurboSquid**: Một trang web uy tín với nhiều asset cho các dự án game và phim.
- Xem xét độ tương thích của các asset với Unity và dự án hiện tại.

## 5. Hỏi AI Cách Sử Dụng Nav Mesh Obstacle

1. Thêm NavMesh Obstacle vào scene:
Bước 1: Chọn đối tượng (GameObject) mà bạn muốn biến thành vật cản.
Bước 2: Trong cửa sổ Inspector, nhấn vào Add Component và tìm kiếm NavMesh Obstacle.
Bước 3: Sau khi thêm NavMesh Obstacle, bạn sẽ thấy một số thuộc tính mà bạn có thể điều chỉnh.
2. Thiết lập thuộc tính cơ bản của NavMesh Obstacle:
Carving: Đây là một thuộc tính quan trọng. Khi bật Carving, vật cản sẽ tự động cắt vào NavMesh để tạo ra vùng cấm điều hướng khi vật cản xuất hiện. Điều này giúp AI nhân vật tránh hoặc thay đổi lộ trình khi có sự thay đổi về môi trường.
Nếu bạn muốn nhân vật AI có thể di chuyển xung quanh vật cản khi nó xuất hiện, bật thuộc tính này.
Carving Move Threshold: Điều chỉnh giá trị này để kiểm soát tần suất cập nhật NavMesh khi vật cản di chuyển.
Carving Time To Stationary: Thời gian cần thiết để xác định khi nào vật cản dừng lại và cập nhật NavMesh.
3. Thiết lập hệ thống NavMesh cho phù hợp với vật cản:
Nếu có nhiều vật cản động trong game, hãy đảm bảo NavMesh được tối ưu hóa bằng cách:
Điều chỉnh giá trị Agent Radius và Agent Height trên NavMesh Agent để đảm bảo AI có thể tính toán đường đi chính xác xung quanh vật cản.
Điều chỉnh NavMesh Baking để đảm bảo vật cản động và carving được tính đến khi tạo NavMesh.
4. Kiểm tra và điều chỉnh:
Khi bạn thêm hoặc thay đổi NavMesh Obstacle, hãy kiểm tra bằng cách chạy game và xem nhân vật AI có phản ứng linh hoạt với vật cản không.
Nếu nhân vật không tránh vật cản như mong đợi, hãy kiểm tra kích thước vật cản, các thuộc tính carving, và NavMesh Agent settings để đảm bảo rằng chúng phù hợp với cấu trúc của game.
- Tìm hiểu cách sử dụng **NavMesh Obstacle** để chặn đường hoặc tạo vật cản cho các nhân vật điều hướng (navigation) trong game.
- Xem xét cách thiết lập các thuộc tính như "carving" để nhân vật tránh hoặc phản ứng linh hoạt với vật cản.
- Kiểm tra và điều chỉnh hệ thống **NavMesh** cho phù hợp với các vật cản mới.
