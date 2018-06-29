<?php

	class MBuku extends CI_Model{

		var $api ='http://localhost:50063/token/';

		//konstruktor
		function __construct(){
			parent:: __construct();
			$this->load->library('curl');
		}

		//Mengirim username dan password
		public function KirimUserdanPass($user,$pass){

      $user = array('username' => $user,'password' => $pass);
			return json_decode($this->curl->simple_post($this->api.'createtoken',$user));

		}

	}

 ?>
