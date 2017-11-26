using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NganHangPT.ulti
{
    class UndoData<T>
    {
        private int hanhDong;
        private int hanhDongTruoc = -1;
        private int viTri;
        private T data;

        public UndoData(int hanhDong, int hanhDongTruoc, int viTri, T data)
        {
            this.hanhDong = hanhDong;
            this.hanhDongTruoc = hanhDongTruoc;
            this.viTri = viTri;
            this.data = data;
        }
        public void setViTri(int viTri)
        {
            this.viTri = viTri;
        }

        public void setHanhDong(int hanhDong)
        {
            this.hanhDong = hanhDong;
        }
        public void setHanhDongTruoc(int hanhDongTruoc)
        {
            this.hanhDongTruoc = hanhDongTruoc;
        }
        public void setData(T data)
        {
            this.data = data;
        }

        public int getHanhDong()
        {
            return hanhDong;
        }
        public int getHanhDongTruoc()
        {
            return hanhDongTruoc;
        }
        public T getData()
        {
            return data;
        }
        public int getViTri()
        {
            return viTri;
        }

    }
}
