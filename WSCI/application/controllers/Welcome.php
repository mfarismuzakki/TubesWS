<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class Welcome extends CI_Controller {

	/**
	 * Index Page for this controller.
	 *
	 * Maps to the following URL
	 * 		http://example.com/index.php/welcome
	 *	- or -
	 * 		http://example.com/index.php/welcome/index
	 *	- or -
	 * Since this controller is set as the default controller in
	 * config/routes.php, it's displayed at http://example.com/
	 *
	 * So any other public methods not prefixed with an underscore will
	 * map to /index.php/welcome/<method_name>
	 * @see https://codeigniter.com/user_guide/general/urls.html
	 */

	public function __construct(){
		parent::__construct();
	}

	public function index()
	{

		$this->load->library('curl');

		//  Setting URL To Fetch Data From
		$this->curl->create('http://c221406a.ngrok.io/api/penulis');

		// //  To Temporarily Store Data Received From Server
		// $this->curl->option('buffersize', 10);

		// //  To support Different Browsers
		// $this->curl->option('useragent', 'Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8 (.NET CLR 3.5.30729)');

		// //  To Receive Data Returned From Server
		// $this->curl->option('returntransfer', 1);

		// //  To follow The URL Provided For Website
		// $this->curl->option('followlocation', 1);

		// //  To Retrieve Server Related Data
		// $this->curl->option('HEADER', true);

		// //  To Set Time For Process Timeout
		// $this->curl->option('connecttimeout', 600);

		//  To Execute 'option' Array Into cURL Library & Store Returned Data Into $data
		$mantap = $this->curl->execute();
		
		$data['mantap'] = json_decode($mantap,true);

		$this->load->view('welcome_message',$data);
	}
}
