<?php

	class MBuku extends CI_Model{

		var $api ='http://localhost:50063/api/';

		//konstruktor
		function __construct(){
			parent:: __construct();
			$this->load->library('curl');
		}


		//pengecekan penulis berdasarkan
		public function CariPenulis($berdasarkan,$key){

			if($key != ""){
				$uri = $this->api.'penulis/'.$key;
			}else{
				$uri = $this->api.'penulis';
			}

			$ch = curl_init($uri);
			curl_setopt($ch, CURLOPT_HTTPHEADER, array('Authorization: bearer '.$this->session->token));
			curl_setopt($ch, CURLOPT_RETURNTRANSFER, 1);

			$data = curl_exec($ch);
			curl_close($ch);
			// echo response output
			return json_decode($data);

		}

		//pengecekan penerbit berdasarkan
		public function CariPenerbit($berdasarkan,$key){

			if($key != ""){
				$uri = $this->api.'penerbit/'.$key;
			}else{
				$uri = $this->api.'penerbit';
			}

			$ch = curl_init($uri);
			curl_setopt($ch, CURLOPT_HTTPHEADER, array('Authorization: bearer '.$this->session->token));
			curl_setopt($ch, CURLOPT_RETURNTRANSFER, 1);

			$data = curl_exec($ch);
			curl_close($ch);
			// echo response output
			return json_decode($data);

		}

		//pengecekan bahasa berdasarkan
		public function CariBahasa($berdasarkan,$key){

			if($key != ""){
				$uri = $this->api.'bahasa/'.$key;
			}else{
				$uri = $this->api.'bahasa';
			}

			$ch = curl_init($uri);
			curl_setopt($ch, CURLOPT_HTTPHEADER, array('Authorization: bearer '.$this->session->token));
			curl_setopt($ch, CURLOPT_RETURNTRANSFER, 1);

			$data = curl_exec($ch);
			curl_close($ch);
			// echo response output
			return json_decode($data);

		}

		//pengecekan kategori berdasarkan
		public function CariKategori($berdasarkan,$key){

			if($key != ""){
				$uri = $this->api.'kategori/'.$key;
			}else{
				$uri = $this->api.'kategori';
			}

			$ch = curl_init($uri);
			curl_setopt($ch, CURLOPT_HTTPHEADER, array('Authorization: bearer '.$this->session->token));
			curl_setopt($ch, CURLOPT_RETURNTRANSFER, 1);

			$data = curl_exec($ch);
			curl_close($ch);
			// echo response output
			return json_decode($data);

		}


		//pengecekan Buku berdasarkan
		public function CariBuku($berdasarkan,$key){

			if($berdasarkan == "Judul Buku"){
				$uri = $this->api.'buku/GetByJudulBuku/'.$key;
			}else if($berdasarkan == "Penulis"){
				$uri = $this->api.'buku/GetByPenulisBuku/'.$key;
			}else if($berdasarkan == "Id"){
				$uri = $this->api.'buku/GetByIdBuku/'.$key;
			}else if($berdasarkan == "Penerbit"){
				$uri = $this->api.'buku/GetByPenerbitBuku/'.$key;
			}else if($berdasarkan == "Bahasa"){
				$uri = $this->api.'buku/GetByBahasaBuku/'.$key;
			}else if($berdasarkan == "Kategori"){
				$uri = $this->api.'buku/GetByKategoriBuku/'.$key;
			}else{
				$uri = $this->api.'buku';
			}

			$ch = curl_init($uri);
			curl_setopt($ch, CURLOPT_HTTPHEADER, array('Authorization: bearer '.$this->session->token));
			curl_setopt($ch, CURLOPT_RETURNTRANSFER, 1);

			$data = curl_exec($ch);
			curl_close($ch);
			// echo response output
			return json_decode($data);
		}


		//menambah peminjam
		public function TambahPeminjaman($data){

			// encode input ke json
			$data = json_encode($data);

			$ch = curl_init($this->api.'peminjaman');
			curl_setopt($ch, CURLOPT_HTTPHEADER, array('Content-Type: application/json','Authorization: bearer '.$this->session->token));
			curl_setopt($ch, CURLOPT_POST, 1);
			curl_setopt($ch, CURLOPT_POSTFIELDS, $data);
			curl_setopt($ch, CURLOPT_RETURNTRANSFER, 1);

			$data = curl_exec($ch);
			curl_close($ch);

			$this->DetailPeminjaman($data);
		}

		public function DetailPeminjaman($data2){

			//menampung data
			$data = $this->db->get('t_tmp')->result();
			$data = json_encode($data);

			foreach ($data as $value)
			{
				$upload = array(
					'id_peminjaman' => $value->id_peminjaman,
					'id_copy_buku' => '1'
				);
			}


			$ch = curl_init($this->api.'Detail_Peminjaman');
			curl_setopt($ch, CURLOPT_HTTPHEADER, array('Content-Type: application/json','Authorization: bearer '.$this->session->token));
			curl_setopt($ch, CURLOPT_POST, 1);
			curl_setopt($ch, CURLOPT_POSTFIELDS, $data);
			curl_setopt($ch, CURLOPT_RETURNTRANSFER, 1);

			$data = curl_exec($ch);
			curl_close($ch);

		}


		//penampungan buku
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
