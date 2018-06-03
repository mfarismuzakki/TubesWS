<legend><?php echo $title;?></legend>
<?php echo validation_errors();?>
<?php echo $message;?>

<form class="form-horizontal" action="<?php echo site_url('CAdmin/EditBahasa/'.$bahasa['id_bahasa']);?>" method="post" enctype="multipart/form-data">
    <div class="form-group">
        <label class="col-lg-2 control-label">Nama Bahasa</label>
        <div class="col-lg-5">
            <input type="text" name="nama_bahasa" class="form-control" value="<?php echo $bahasa['nama_bahasa'];?>">
        </div>
    </div>
   

    <div class="form-group well">
        <button class="btn btn-primary"><i class="glyphicon glyphicon-hdd"></i> Update</button>
        <a href="<?php echo site_url('CAdmin/Bahasa');?>" class="btn btn-default">Kembali</a>
    </div>
</form>
