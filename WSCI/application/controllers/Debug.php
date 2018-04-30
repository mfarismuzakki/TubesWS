<?php 
	defined('BASEPATH') OR exit('No direct script access allowed');


	class Debug extends CI_Controller{


		//konstruktor
		public function __construct(){
			parent::__construct();
		}

		public function index(){

			$this->load->library('curl');

			$this->curl->create('http://localhost:50063/api/bahasa');
			$tmp = $this->curl->execute();
			$data['bahasa'] = json_decode($tmp,true);

			$this->curl->create('http://localhost:50063/api/deskripsi');
			$tmp = $this->curl->execute();
			$data['deskripsi'] = json_decode($tmp,true);

			$this->curl->create('http://localhost:50063/api/kategori');
			$tmp = $this->curl->execute();
			$data['kategori'] = json_decode($tmp,true);

			$this->curl->create('http://localhost:50063/api/penerbit');
			$tmp = $this->curl->execute();
			$data['penerbit'] = json_decode($tmp,true);

			$this->curl->create('http://localhost:50063/api/penulis');
			$tmp = $this->curl->execute();
			$data['penulis'] = json_decode($tmp,true);

			$data['menu'] = "Home";
			$this->load->view('header',$data);
			$this->load->view('debug',$data);
		} 

		public function Bahasa(){

			$this->load->library('curl');

			$this->curl->create('http://localhost:50063/api/bahasa');
			$tmp = $this->curl->execute();
			$data['bahasa'] = json_decode($tmp,true);

			$data['menu'] = "Bahasa";

			$this->load->view('header',$data);
			$this->load->view('bahasa',$data);
		}

		public function Deskripsi(){

			$this->load->library('curl');

			$this->curl->create('http://localhost:50063/api/deskripsi');
			$tmp = $this->curl->execute();
			$data['deskripsi'] = json_decode($tmp,true);

			$data['menu'] = "Deskripsi";

			$this->load->view('header',$data);
			$this->load->view('deskripsi',$data);
		}

		public function Kategori(){

			$this->load->library('curl');

			$this->curl->create('http://localhost:50063/api/kategori');
			$tmp = $this->curl->execute();
			$data['kategori'] = json_decode($tmp,true);

			$data['menu'] = "Kategori";

			$this->load->view('header',$data);
			$this->load->view('kategori',$data);
		}

		public function Penerbit(){

			$this->load->library('curl');

			$this->curl->create('http://localhost:50063/api/penerbit');
			$tmp = $this->curl->execute();
			$data['penerbit'] = json_decode($tmp,true);

			$data['menu'] = "Penerbit";

			$this->load->view('header',$data);
			$this->load->view('penerbit',$data);
		}

		public function Penulis(){

			$this->load->library('curl');

			$this->curl->create('http://localhost:50063/api/penulis');
			$tmp = $this->curl->execute();
			$data['penulis'] = json_decode($tmp,true);
			
			$data['menu'] = "Penulis";

			$this->load->view('header',$data);
			$this->load->view('penulis',$data);
		}

		public function JudulBuku(){

			$this->load->library('curl');

			$this->curl->create('http://localhost:50063/api/judulbuku');
			$tmp = $this->curl->execute();
			$data['penulis'] = json_decode($tmp,true);
			
			$data['menu'] = "JudulBuku";

			$this->load->view('header',$data);
			$this->load->view('judulbuku',$data);
		}
	}
 ?>