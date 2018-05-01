<?php 
	
	class MBuku extends CI_Model{

		var $api ='http://d59acffd.ngrok.io/api/';

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

		//pengecekan penerbit berdasarkan
		public function CariBahasa($berdasarkan,$key){

			return json_decode($this->curl->simple_get($this->api.'bahasa'));

		}

		//pengecekan penerbit berdasarkan
		public function CariKategori($berdasarkan,$key){

			return json_decode($this->curl->simple_get($this->api.'kategori'));

		}




	}

 ?>