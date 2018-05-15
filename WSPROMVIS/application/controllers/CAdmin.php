<?php 
	
	defined('BASEPATH') OR exit('No direct script access allowed');
	
	class CAdmin extends CI_Controller{

		var $current = array(
		'buku' => null,
		'penulis' => null,
		'penerbit' => null,
		'kategori' => null,
		'bahasa' => null,
		'daftar_peminjaman' => null,
		'waktu_pengembalian' => null,
		'daftar_transaksi' => null
		);




		//kosntruktor
		public function __construct(){
			parent:: __construct();
		}

		//cek status login
		function Login_Check(){

			if(!$this->session->loged_in && $this->session->username == "admin"){
				redirect('CAdmin');
			}
		} 

		//index
		public function index(){
			$this->Login_Check();

			$active['status'] = $this->current;
			$this->load->view('admin/VAheader');
			$this->load->view('admin/VAsidebar',$active);

		}


		//logut
		public function Logout(){

			$this->session->sess_destroy();
			redirect('UserHome');
		}


	}

 ?>