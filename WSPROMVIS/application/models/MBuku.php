<?php 
	
	class MBuku extends CI_Model{

		var $api ='http://9fb3da38.ngrok.io/api/';

		//konstruktor
		function __construct(){
			parent:: __construct();
			$this->load->library('curl');
		}


		//pengecekan penulis berdasarkan
		public function CariPenulis($berdasarkan,$key){

			return json_decode($this->curl->simple_get($this->api.'penulis'));

		}

		//pengecekan penerbit berdasarkan
		public function CariPenerbit($berdasarkan,$key){

			return json_decode($this->curl->simple_get($this->api.'penerbit'));

		}

		//pengecekan bahasa berdasarkan
		public function CariBahasa($berdasarkan,$key){

			return json_decode($this->curl->simple_get($this->api.'bahasa'));

		}

		//pengecekan kategori berdasarkan
		public function CariKategori($berdasarkan,$key){

			return json_decode($this->curl->simple_get($this->api.'kategori'));

		}


		//pengecekan Buku berdasarkan
		public function CariBuku($berdasarkan,$key){

			return json_decode($this->curl->simple_get($this->api.'buku'));

		}


	}

 ?>