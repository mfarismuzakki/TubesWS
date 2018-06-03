<?php 
	
	class MAdmin extends CI_Model{
		var $api ='http://localhost:50062/api/';

		//konstruktor
		function __construct(){
			parent:: __construct();
			$this->load->library('curl');
		}


		//pengecekan penulis berdasarkan
		public function GetData($endLink){

			$uri = $this->api.$endLink;

			$ch = curl_init($uri);
			curl_setopt($ch, CURLOPT_HTTPHEADER, array('Authorization: bearer '.$this->session->token));
			curl_setopt($ch, CURLOPT_RETURNTRANSFER, 1);
    		
			$data = curl_exec($ch);
			curl_close($ch);
			// echo response output
			return json_decode($data);

		}

		public function TambahData($endLink, $data){
			
			// encode input ke json
			$data = json_encode($data);

			$ch = curl_init($this->api.$endLink);
			curl_setopt($ch, CURLOPT_HTTPHEADER, array('Content-Type: application/json','Authorization: bearer '.$this->session->token));
			curl_setopt($ch, CURLOPT_POST, 1);
			curl_setopt($ch, CURLOPT_POSTFIELDS, $data);
			curl_setopt($ch, CURLOPT_RETURNTRANSFER, 1);
    		
			$data = curl_exec($ch);
			curl_close($ch);
		}

		public function UpdateData($endLink, $data){
			
			// encode input ke json
			$data = json_encode($data);

			$ch = curl_init($this->api.$endLink);
			curl_setopt($ch, CURLOPT_HTTPHEADER, array('Content-Type: application/json','Authorization: bearer '.$this->session->token));
			curl_setopt($ch, CURLOPT_CUSTOMREQUEST, 'PUT');
			curl_setopt($ch, CURLOPT_POSTFIELDS, $data);
			curl_setopt($ch, CURLOPT_RETURNTRANSFER, 1);
    		
			$data = curl_exec($ch);
			curl_close($ch);
		}

		public function DeleteData($endLink){

			$ch = curl_init($this->api.$endLink);
			curl_setopt($ch, CURLOPT_HTTPHEADER, array('Content-Type: application/json','Authorization: bearer '.$this->session->token));
			curl_setopt($ch, CURLOPT_CUSTOMREQUEST, 'DELETE');
			curl_setopt($ch, CURLOPT_RETURNTRANSFER, 1);
    		
			$data = curl_exec($ch);
			curl_close($ch);
		}

		public function CekData($id, $endLink){
			
		}

		
	}



 ?>