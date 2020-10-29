Vagrant.configure("2") do |config|

  config.vm.box = "centos/7"
  config.vm.hostname = "mytestserver"
  config.disksize.size = "30GB"  
  config.vm.provider "virtualbox" do |vb|
     vb.check_guest_additions = false
     vb.name = "mytestserver"
     vb.gui = true
     vb.cpus = 2
     vb.memory = "2048"
  end
   
# ansible provision
  config.vm.provision "ansible" do |ansible|
     ansible.playbook = "playbook.yml"
  end	

end