<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class UserHome extends CI_Controller {

	function __construct(){
		parent::__construct();
		$this->load->library('curl');
		$this->curl->create('http://localhost:50062/api/');
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
			$this->curl->http_login($username,$password);
			$userdata = array(
				'username' => 'admin',
				'password' => 'admin',
				'loged_in' => TRUE
			);
			$this->session->set_userdata($userdata);

			redirect('CUserCari');
		}else{
			$this->index();
		}

	}
}
