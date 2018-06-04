<a href="<?php echo site_url('CAdmin/TambahPenulis');?>" class="btn btn-primary"><i class="glyphicon glyphicon-plus"></i> Tambah</a>
<hr>
<?php echo $message;?>
<Table class="table table-striped">
    <thead>
        <tr>
            <td>No.</td>
            <td>Nama</td>
            <td>Tempat Lahir</td>
            <td>Tanggal Lahir</td>
            <td>Domisili</td>
            <td colspan="2"></td>
        </tr>
    </thead>
    <?php $no=0; foreach($penulis as $row ): $no++;?>
    <tr>
        <td><?php echo $no;?></td>
        <td><?php echo $row->nama_penulis;?></td>
        <td><?php echo $row->tempat_lahir;?></td>
        <td><?php echo $row->tanggal_lahir;?></td>
        <td><?php echo $row->domisili;?></td>
        <td><a href="<?php echo site_url('CAdmin/EditPenulis/'.$row->id_penulis);?>"><i class="glyphicon glyphicon-edit"></i></a></td>
        <td><a href="#" class="hapus" kode="<?php echo $row->id_penulis;?>"><i class="glyphicon glyphicon-trash"></i></a></td>
    </tr>
    <?php endforeach;?>
</Table>
<?php echo $pagination;?>

<script>
    $(function(){
        $(".hapus").click(function(){
            var kode=$(this).attr("kode");
            
            $("#idhapus").val(kode);
            $("#myModal").modal("show");
        });
        
        $("#konfirmasi").click(function(){
            var kode=$("#idhapus").val();
            
            $.ajax({
                url:"<?php echo site_url('CAdmin/Hapus/Penulis');?>",
                type:"POST",
                data:"id="+kode,
                cache:false,
                success:function(html){
                    location.href="<?php echo site_url('CAdmin/Penulis/delete_success');?>";
                }
            });
        });
    });
</script>
