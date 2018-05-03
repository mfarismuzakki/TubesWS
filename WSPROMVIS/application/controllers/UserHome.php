<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class UserHome extends CI_Controller {

	function __construct(){
		parent::__construct();
		$this->load->library('curl');
		$this->curl->create('http://944c3584.ngrok.io/token/createtoken');
	}


	public function index()
	{
		if($this->session->loged_in){
			redirect('CUsercari');
		}else{
			$this->load->view('user/VUheader');
			$this->load->view('Vlogin');
		}
	}

	public function Cek(){

		$username = $this->input->post('username');
		$password = $this->input->post('password');


		if(($username =='admin' && $password =='admin')){

			$data = '{"username" : "admin" , "password" : "admin"}' ;

			$this->curl->option(CURLOPT_HTTPHEADER, array('Content-type: application/json; Charset=UTF-8'));
			$this->curl->post($data);	
			$token = $this->curl->execute();	

			$userdata = array(
				'username' => 'admin',
				'password' => 'admin',
				'token' => $token,
				'loged_in' => TRUE
			);
			$this->session->set_userdata($userdata);
			redirect('CUserCari');
		}else{
			$this->index();
		}

	}
}
