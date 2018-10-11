class Solution
  def sock_merchant(_number_of_socks, _sock_colors)
    found_pairs = 0
    colors = []
    _sock_colors.each do |sock_color|
      if !colors.include? sock_color
        colors.push(sock_color)
      else
        found_pairs += 1
        colors.delete(sock_color)
      end
    end
    found_pairs
  end
end
