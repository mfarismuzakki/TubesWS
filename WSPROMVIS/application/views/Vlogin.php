<link rel="stylesheet" type="text/css" href="<?php echo base_url('css/signin.css'); ?>">
  </head>
    <body class="text-center">
      <form class="form-signin" method="post" action="<?php echo site_url('UserHome/cek'); ?>">
        <h1 class="h3 mb-3 font-weight-normal">Please sign in</h1>
        <label for="inputEmail" class="sr-only">Username</label>
        <input type="text"  class="form-control" placeholder="Username" required autofocus name="username">
        <label for="inputPassword" class="sr-only">Password</label>
        <input type="password" id="inputPassword" class="form-control" placeholder="Password" required name="password">

        <button class="btn btn-lg btn-primary btn-block" type="submit">Sign in</button>
        <p class="mt-5 mb-3 text-muted"> Perpustakaan Promvis&copy; 2017-2018</p>
      </form>
    </body>