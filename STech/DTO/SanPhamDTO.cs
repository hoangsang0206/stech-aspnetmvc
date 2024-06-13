﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STech.DTO
{
    public class SanPhamDTO
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public Nullable<decimal> GiaGoc { get; set; }
        public Nullable<int> BaoHanh { get; set; }
        public decimal GiaBan { get; set; }
        public string HinhAnh { get; set; }
        public int Tonkho {  get; set; }
        public DanhMucDTO DanhMuc { get; set; }
        public HangSxDTO HangSX { get; set; }

        public SanPhamDTO() { }

        public SanPhamDTO(string maSP, string tenSP, decimal? giaGoc, decimal giaBan, string hinhAnh, int tonkho, DanhMucDTO danhMuc, HangSxDTO hangSX, int? baoHanh)
        {
            MaSP = maSP;
            TenSP = tenSP;
            GiaGoc = giaGoc;
            GiaBan = giaBan;
            HinhAnh = hinhAnh;
            Tonkho = tonkho;
            DanhMuc = danhMuc;
            HangSX = hangSX;
            BaoHanh = baoHanh;
        }
    }
}