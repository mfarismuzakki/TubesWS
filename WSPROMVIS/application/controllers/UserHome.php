<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class UserHome extends CI_Controller {

	var $status = "";

	function __construct(){
		parent::__construct();
		$this->load->library('curl');
		$this->curl->create('http://localhost:50063/token/CreateToken');
	}


	public function index()
	{
		if($this->session->loged_in){
			redirect('CUsercari');
		}else{
			$stat['status'] = $this->status;
			$this->load->view('user/VUheader');
			$this->load->view('Vlogin',$stat);
		}
	}

	public function Cek(){

		$username = $this->input->post('username');
		$password = $this->input->post('password');



		$data = '{"username" : "'.$username.'" , "password" : "'.$password.'" }'   ;


		$this->curl->option(CURLOPT_HTTPHEADER, array('Content-type: application/json; Charset=UTF-8'));
		$this->curl->post($data);
		$token = $this->curl->execute();

		if($token == ""){

			$this->status = "Username / password tidak valid";
			$this->index();

		}else{

			$token = (json_decode($token));

			$userdata = array(
				'username' => $username,
				'password' => $password,
				'token' => $token->acces_token,
				'loged_in' => TRUE
			);
			$this->session->set_userdata($userdata);
			if($username != "admin"){
				redirect('CUserCari');
			}else{
				redirect('CAdmin');
			}


		}
	}
}
