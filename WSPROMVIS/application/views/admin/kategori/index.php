<a href="<?php echo site_url('CAdmin/TambahKategori');?>" class="btn btn-primary"><i class="glyphicon glyphicon-plus"></i> Tambah</a>
<hr>
<?php echo $message;?>
<Table class="table table-striped">
    <thead>
        <tr>
            <td>No.</td>
            <td>Nama Kategori</td>
            <td colspan="2"></td>
        </tr>
    </thead>
    <?php $no=0; foreach($kategori as $row ): $no++;?>
    <tr>
        <td><?php echo $no;?></td>
        <td><?php echo $row->nama_kategori;?></td>
        <td><a href="<?php echo site_url('CAdmin/EditKategori/'.$row->id_kategori);?>"><i class="glyphicon glyphicon-edit"></i></a></td>
        <td><a href="#" class="hapus" kode="<?php echo $row->id_kategori;?>"><i class="glyphicon glyphicon-trash"></i></a></td>
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
                url:"<?php echo site_url('CAdmin/Hapus/Kategori');?>",
                type:"POST",
                data:"id="+kode,
                cache:false,
                success:function(html){
                    location.href="<?php echo site_url('CAdmin/Kategori/delete_success');?>";
                }
            });
        });
    });
</script>
