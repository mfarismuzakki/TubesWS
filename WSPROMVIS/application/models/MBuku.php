<?php 
	
	class MBuku extends CI_Model{

		var $api ='http://localhost:5000/api/';

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

			if($berdasarkan == null){
				return json_decode($this->curl->simple_get($this->api.'buku/'.$key));
			}else{
				return json_decode($this->curl->simple_get($this->api.'buku'));
				
			}
		}


		//menambah peminjam
		public function TambahPeminjaman($data){
			
			//encode input ke json
			$data = json_encode($data);

			$this->curl->create($this->api.'peminjaman');
			$this->curl->option(CURLOPT_HTTPHEADER, array('Content-type: application/json; Charset=UTF-8'));
			$this->curl->post($data);

			$this->curl->execute();	
			$this->curl->error_string;	
		
			if($this->curl->error_string == "ok"){

			}else{
				echo $this->curl->error_string;
			}
		}

		public function TampungBuku($data){
			$this->db->insert('t_tmp',$data);
		}

		public function getTampungBuku(){
			return $this->db->get('t_tmp');
		}

		public function deleteTampungBuku($id_buku){
			$this->db->delete('t_tmp',array('id_buku' => $id_buku));
		}

		public function TrunCate(){
			$this->db->query('truncate table t_tmp');
		}

	}

 ?>