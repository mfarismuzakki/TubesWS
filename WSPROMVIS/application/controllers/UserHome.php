<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class UserHome extends CI_Controller {

	public function index()
	{
		$this->load->helper('url');

		$this->load->view('user/header');
		$this->load->view('user/sidebar');
	}
}
