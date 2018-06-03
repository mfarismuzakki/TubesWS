<legend><?php echo $title;?></legend>
<?php echo validation_errors();?>
<?php echo $message;?>

<form class="form-horizontal" action="<?php echo site_url('CAdmin/EditAnggota/'.$anggota['id_anggota']);?>" method="post" enctype="multipart/form-data">
    <div class="form-group">
        <label class="col-lg-2 control-label">Nama</label>
        <div class="col-lg-5">
            <input type="text" name="nama_anggota" class="form-control" value="<?php echo $anggota['nama_anggota'];?>">
        </div>
    </div>
    <div class="form-group">
        <label class="col-lg-2 control-label">Jenis Kelamin</label>
        <div class="col-lg-5">
            <select name="jenis_kelamin" class="form-control">
                <option value="<?php echo $anggota['jenis_kelamin'];?>"><?php echo $anggota['jenis_kelamin'];?></option>
                <option value="L">L</option>
                <option value="P">P</option>
            </select>
        </div>
    </div>
    <div class="form-group">
        <label class="col-lg-2 control-label">Tempat Lahir</label>
        <div class="col-lg-5">
            <input type="text" name="tempat_lahir" class="form-control" value="<?php echo $anggota['tempat_lahir'];?>">
        </div>
    </div>
    <div class="form-group">
        <label class="col-lg-2 control-label">Tanggal Lahir</label>
        <div class="col-lg-5">
            <input type="text" name="tanggal_lahir" id="tanggal" class="form-control" value="<?php echo $anggota['tanggal_lahir'];?>">
        </div>
    </div>
    <div class="form-group">
        <label class="col-lg-2 control-label">No Telepon</label>
        <div class="col-lg-5">
            <input type="text" name="notelepon" class="form-control" value="<?php echo $anggota['notelepon'];?>">
        </div>
    </div>
    <div class="form-group">
        <label class="col-lg-2 control-label">Alamat</label>
        <div class="col-lg-5">
            <input type="text" name="alamat" class="form-control" value="<?php echo $anggota['alamat'];?>">
        </div>
    </div>

    <div class="form-group well">
        <button class="btn btn-primary"><i class="glyphicon glyphicon-hdd"></i> Update</button>
        <a href="<?php echo site_url('CAdmin/Anggota');?>" class="btn btn-default">Kembali</a>
    </div>
</form>
