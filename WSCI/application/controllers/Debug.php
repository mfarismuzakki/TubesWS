<?php 
	defined('BASEPATH') OR exit('No direct script access allowed');


	class Debug extends CI_Controller{


		//konstruktor
		public function __construct(){
			parent::__construct();
		}

		public function index(){

			$this->load->library('curl');

			$this->curl->create('http://c221406a.ngrok.io/api/penulis');
			$tmp = $this->curl->execute();
			$data['penulis'] = json_decode($tmp,true);

			$this->curl->create('http://c221406a.ngrok.io/api/bahasa');
			$tmp = $this->curl->execute();
			$data['bahasa'] = json_decode($tmp,true);

			$this->curl->create('http://c221406a.ngrok.io/api/kategori');
			$tmp = $this->curl->execute();
			$data['kategori'] = json_decode($tmp,true);

			$this->curl->create('http://c221406a.ngrok.io/api/penerbit');
			$tmp = $this->curl->execute();
			$data['penerbit'] = json_decode($tmp,true);

			$this->load->view('debug',$data);
		} 

		public function Penulis(){

			$this->load->library('curl');

			$this->curl->create('http://c221406a.ngrok.io/api/penulis');
			$tmp = $this->curl->execute();
			$data['penulis'] = json_decode($tmp,true);

			$this->load->view('penulis',$data);


		}



	}


 ?>